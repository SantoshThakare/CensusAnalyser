﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyser
{
    public class StateCodeDataDAO
    {
        public string SrNo;
        public string State;
        public string TIN;
        public string StateCode;
        public StateCodeDataDAO(string serialNumber, string state, string TIN, string stateCode)
        {
            this.SrNo = serialNumber;
            this.State = state;
            this.TIN = TIN;
            this.StateCode = stateCode;
        }
    }
}
