using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Text.RegularExpressions;

namespace SpellmanXRVGui_Logging
{
    public partial class MainForm : Form
    {
        #region Variables

        bool GeneratorConnected = false;
        const string DTECHRS232PNPID = "VID_0403+PID_6001";
        private string RS232Port;
        /// <summary>
        /// class to store the usb device found for later procesing
        /// </summary>
        class USBDeviceInfo
        {
            public USBDeviceInfo(string did = "", string vid = "", string desc = "", string name = "")
            {
                DID = did;
                VID = vid;
                DESC = desc;
                NAME = name;
            }
            public string DID { get; private set; }
            public string VID { get; private set; }
            public string DESC { get; private set; }
            public string NAME { get; private set; }
        }

        
        #endregion

        #region Objects
        /// <summary>
        /// stores the Generator Class for storing all information to later be logged
        /// </summary>
        SpellmanGenerator gen;
        /// <summary>
        /// Object to handle invocation for all GUI interactions when necessary
        /// </summary>
        ThreadSaveControls TSC;


        #region Non UI Methods

        /// <summary>
        /// simple check method for connection to generator | a double getter
        /// </summary>
        /// <returns></returns>
        private bool CheckForGenerator()
        {
            if (GeneratorSerialPort != null && GeneratorConnected) { return true; }
            return false;
        }

        /// <summary>
        /// handles the incoming data from the serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataRecievedHandler_Gen(object sender,SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string inData = sp.ReadExisting();
                //we need to tokenize the data first | we will only have responses here, but still a good practice | split via new lines and ETX characters
                string[] tokens = inData.Split(new string[] { "\n", "\r\n" , "\x03"}, StringSplitOptions.None);
                //If this doesnt work properly, simply remove it
                foreach (var token in tokens)
                {
                    gen.ParseSerialData(token);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling incoming generator data: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Uses Regex to remove all non number characters from the string and returns a COMX string
        /// </summary>
        /// <returns></returns>
        private string GetPortNumber(string s)
        {
            return "COM" + Regex.Replace(s, @"[^\d]", "");
        }

        /// <summary>
        /// Tries to find the port via PNP Entitiy query
        /// if nothing is found, false is returned
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        private bool InitializeGeneraterSerialPort(ref SerialPort sp)
        {
            //Search through Win32 for all PNP devices that have the porper PNP ID
            Console.WriteLine("Finding all RS232 Devices");

            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();
            //now set up the query using a management collection object
            ManagementObjectCollection collection;
            //now use a managementsearcher to find all PNP devices as
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_PnpEntity"))
                collection = searcher.Get();
            Console.WriteLine(collection.Count);
            foreach (var device in collection)
            {

                
                if (Convert.ToString(device.GetPropertyValue("PNPDeviceID")).Contains(DTECHRS232PNPID))
                {
                    devices.Add(new USBDeviceInfo(
                        (string)device.GetPropertyValue("DeviceID"),
                        (string)device.GetPropertyValue("PNPDeviceID"),
                        (string)device.GetPropertyValue("Description"),
                        (string)device.GetPropertyValue("Name")
                         ));

                    Console.WriteLine("Device ID: " + (string)device.GetPropertyValue("DeviceID") +
                                     // "||PNP ID:    " + (string)device.GetPropertyValue("PNPDeviceID") +
                                     // "||Desc:      " + (string)device.GetPropertyValue("Dexcription") +
                                     "||Name:      " + (string)device.GetPropertyValue("Name"));
                    RS232Port = GetPortNumber((string)device.GetPropertyValue("Name"));
                }
                    
                    //Now that we have the device info stored; get the com port name
                    //RS232Port = GetPortNumber((string)device.GetPropertyValue("Name"));
                }
                TSC.WriteAttributeThreadSafe<ToolStripTextBox>(ref toolStripTextBoxGeneratorComPort, RS232Port);
                Console.WriteLine("Generator found at: " + RS232Port);
                //now initialize the serial port

                //handle the SP being null or open
                if (sp == null) { sp = new SerialPort(); }
                if (sp.IsOpen) { sp.Close(); }
                sp.PortName = RS232Port;
                sp.DataBits = 8;
                sp.BaudRate = 115200;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                Console.WriteLine("Successfully connected to Generator Com Port!");
                collection.Dispose();
                try
                {
                    if(sp.IsOpen){ sp.Close();}
                    //update connection status
                    GeneratorConnected = true;
                    sp.Open();
                    //Start the event watcher for data arrived as well
                    sp.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler_Gen);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not connect to Generator; Com Port is busy" + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }
                
            
        }

        #endregion

        #endregion
        public MainForm()
        {
            InitializeComponent();
            TSC = new ThreadSaveControls();
            ApplySettings();
        }


        private void ApplySettings()
        {
            TSC.WriteAttributeThreadSafe<TextBox>(ref textBoxGeneratorScalingkV,Properties.Settings.Default.GenMaxkV.ToString("N2"));
            TSC.WriteAttributeThreadSafe<TextBox>(ref textBoxGeneratorScailngmA, Properties.Settings.Default.GenMaxmA.ToString("N2"));
            TSC.WriteAttributeThreadSafe<TextBox>(ref textBoxGeneratorScalingFilCurrent, Properties.Settings.Default.GenMaxFilCurrent.ToString("N2"));
            //now update the values for the scaling per bits
            double scaling = Properties.Settings.Default.GenMaxkV / Properties.Settings.Default.GeneratorBits;
            TSC.WriteAttributeThreadSafe < TextBox>(ref textBoxGeneratorScalingVoltsPerBit, (Properties.Settings.Default.GenMaxkV / Properties.Settings.Default.GeneratorBits).ToString("N6"));
            TSC.WriteAttributeThreadSafe<TextBox>(ref textBoxGeneratorScalingmAPerBit, (Properties.Settings.Default.GenMaxmA / Properties.Settings.Default.GeneratorBits).ToString("N6"));
            TSC.WriteAttributeThreadSafe<TextBox>(ref textBoxGeneratorScalingAPerBit, (Properties.Settings.Default.GenMaxFilCurrent / Properties.Settings.Default.GeneratorBits).ToString("N6"));
        }

        /// <summary>
        /// Searches for the Generator using the D-Tech DB9 connector as the source
        /// Calls the search over all PNP devices, initializes Serial Port on that com port
        /// send a signal to get the model of the generator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Alias toolStripButtonConnectToGenerator
            //Search for Generator Com Port via PNP device search 
            InitializeGeneraterSerialPort(ref GeneratorSerialPort);
            
        }

        /// <summary>
        /// Sends the command to the generator via
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendkVDemand_Click(object sender, EventArgs e)
        {
            //make sure the generator is connected
            if (!CheckForGenerator()) { MessageBox.Show("Generator Not Found", "Generator Not Found", MessageBoxButtons.OK); return; }
            //convert the requested value to a scaled format

        }

        private void buttonSendmADemand_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendFilamentPreHeatLimit_Click(object sender, EventArgs e)
        {

        }
       
    }
}
