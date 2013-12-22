using System;
using CIMAgent;


    public class Script
    {
        public int SetupWrapupUI(String iid)
        {
            return CIMAgent.Global.AddWrapupCodeEx("", "", "", true);
        }
    }
