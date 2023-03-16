using System;
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

        }

        /// <summary>
        /// Takes the parameter and parses out the generator statuss
        /// </summary>
        /// <param name="s"></param>
        private void ParseGeneratorStatus(string[] s)
        {

        }
        #endregion
    }
}
