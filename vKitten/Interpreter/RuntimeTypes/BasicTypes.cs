using System;
using System.Collections.Generic;
using System.Text;

namespace vKitten.Interpreter.RuntimeTypes
{
    class ivKittenInteger : ivKittenObject
    {
        public int rVal;
    }

    class ivKittenFloat : ivKittenObject
    {
        public double rVal;
    }

    class ivKittenBoolean : ivKittenObject
    {
        public bool rVal;
    }

    class ivKittenString : ivKittenObject
    {
        public ivKittenString(string s) : base()
        {
            rVal = s;
        }
        public string rVal;
    }
}