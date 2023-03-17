using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellmanXRVGui_Logging
{
    class SpellmanGenerator
    {
        #region Variables
        //Measured Signals
        double mA_Measured;
        double kV_Measured;
        double filamentCurrent_Measured;
        //Demand Signals
        double mA_Demand;
        double kV_demand;
        //Control setpoints
        double Filament_Limit;
        double Filament_PreHeadLimit;
        //Logging Variables
        string rawData;
        //Generator Status values | arg 1 -> 17
        bool HV_Enabled;            // Arg1 |
        bool Interlock1;            // Arg2 |
        bool Interlock2;            // Arg3 |
        bool ECRMode;               // Arg4 |
        bool PSFault;               // Arg5 |
        bool RemoteOrLocal;         // Arg6 | 0 = remote, 1 = local
        bool FilamentEnabled;       // Arg7 | 0 == disabled, 1 == enabled
        bool FilamentType;          // Arg8 | 1 == large, 0 == small
        bool PreWarn;               // Arg9 | 1 == xrays eminent
        bool ConfirmLargeFilament;  // Arg10| 1 == large filament confirmation
        bool ConfirmSmallFilament;  // Arg11| 1 == small filament confirmation
        bool PSReady;               // Arg16| 1 PSU is ready
        bool InternalInterlock;     // Arg17| 1 == Internal Interlock Closed
        #endregion

        #region Commands
        //Due to some commands required arguments, we will define true commands dynamically
        /// <summary>
        /// Request to Generator from device to get mA kV and filament current
        /// </summary>
        public string Command19 = "\x02" + "\x31" + "\x39" + "\x2C" + "\x6A" + "\x03";
        /// <summary>
        /// Request to Generator from device to get generator status
        /// </summary>
        public string Command22 = "\x02" + "\x32" + "\x32" + "\x2C" + "\x6A" + "\x03";

        #endregion

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public SpellmanGenerator()
        {

        }

        #region Public Methods
        /// <summary>
        /// Takes the given string and parses it into the appropriate command and stores the data accordingly
        /// </summary>
        /// <param name="s"></param>
        public void ParseSerialData(string s)
        {
            //parse the string
            string[] tokens = s.Split(',');
            //Determine the response type
            switch (tokens[0].Substring(1))
            {
                case "19":
                    ParseAnalogReadBack(tokens);
                    break;
                case "22":
                    ParseGeneratorStatus(tokens);
                    break;
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Takes the parameter and extracts the mA, kV, and measured filament
        /// </summary>
        /// <param name="s"></param>
        private void ParseAnalogReadBack(string[] s)
        {
            //The syntax of the data coming in should be in the form 
            //<STX><19><,><kV><,><mA><,><Filament Current><,>...
            //We have already split by commas, so ignore them for counting arguments
            try
            {
                kV_Measured = Convert.ToDouble(s[1]);
                mA_Measured = Convert.ToDouble(s[2]);
                filamentCurrent_Measured = Convert.ToDouble(s[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error parsing Command 19 AnalogReadBacks: " + ex.Message);
            }
            
            
        }

        /// <summary>
        /// Takes the parameter and parses out the generator statuss
        /// </summary>
        /// <param name="s"></param>
        private void ParseGeneratorStatus(string[] s)
        {
            //Simlar to ParseAnalogReadBack(), we know the argument indexing, use the same method to extract from this syntax
            //<STX><22><,><A1><,><A2>....
            try
            {
                HV_Enabled = Convert.ToBoolean(s[1]);
                Interlock1 = Convert.ToBoolean(s[2]);
                Interlock2 = Convert.ToBoolean(s[3]);
                PSFault = Convert.ToBoolean(s[5]);
                RemoteOrLocal = Convert.ToBoolean(s[6]);
                FilamentEnabled = Convert.ToBoolean(s[7]);
                PreWarn = Convert.ToBoolean(s[9]);
                PSReady = Convert.ToBoolean(s[16]);
                InternalInterlock = Convert.ToBoolean(s[17]);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error parsing Command 22 Generator Status: " + ex.Message);
            }
            

        }

        public int GenerateCheckSum(string[] cmd)
        {
            int sum = 0;
            try
            {
                foreach (var s in cmd)
                {
                    //remove the STX and ETX from the addition
                    if (s != "\x02" || s != "\x03")
                    {
                        sum += Convert.ToInt32(s);
                    }
                }
                if(sum == 0) { Console.WriteLine("Error Generating Checksum, sum == 0"); return 0; }
                //now perform 2's compliment using | 1's compliment is in parentheses
                int cs = 1 + (sum ^ 255);
                //truncate to the last 8 bits | in doing so, we need to really truncate to the last 7 bits
                cs &= 127; //removes all 1's due to AND-ing them with 0000 0000 0000 0000 0000 0000 0111 1111
                //now set the 6th bit to be 1
                cs |= 127;
                //This is our Checksum value!
                return cs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Generating CheckSum: " + ex.Message);
            }
            return 0;
        }
        

        #endregion
    }
}
