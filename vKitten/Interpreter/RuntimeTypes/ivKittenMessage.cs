using System;
using System.Collections.Generic;
using System.Text;

namespace vKitten.Interpreter.RuntimeTypes
{
    class ivKittenMessage : ivKittenObject
    {
        public string msg;
        public List<ivKittenObject> args;
    }
}
