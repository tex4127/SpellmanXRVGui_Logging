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

namespace SpellmanXRVGui_Logging
{
    public partial class MainForm : Form
    {
        #region Variables

        bool GeneratorConnected = false;

        #endregion

        #region Objects
        /// <summary>
        /// stores the Generator Class for storing all information to later be logged
        /// </summary>
        SpellmanGenerator gen;


        #region Non UI Methods

        private bool CheckForGenerator()
        {
            if (GeneratorSerialPort != null && GeneratorConnected) { return true; }
            return false;
        }

        /// <summary>
        /// Tries to find the port via PNP Entitiy query
        /// if nothing is found, false is returned
        /// </summary>
        /// <param name="sp"></param>
        /// <returns></returns>
        private bool InitializeGeneraterSerialPort(ref SerialPort sp)
        {

        }

        #endregion

        #endregion
        public MainForm()
        {
            InitializeComponent();
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
            //Search for Generator Com Port via PNP device search =

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

        }

        private void buttonSendmADemand_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendFilamentPreHeatLimit_Click(object sender, EventArgs e)
        {

        }
       
    }
}
