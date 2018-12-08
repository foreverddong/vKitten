using System;
using System.Collections.Generic;
using System.Text;
using vKitten.Interpreter.RuntimeTypes;

namespace vKitten.Interpreter
{
    class ivKittenObject
    {
        public ivKittenClass isa;
        public Dictionary<string,ivKittenObject> members;
        public ivKittenObject()
        {
            members = new Dictionary<string, ivKittenObject>();
        }
    }
}
