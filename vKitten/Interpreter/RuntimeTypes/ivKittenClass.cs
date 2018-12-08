using System;
using System.Collections.Generic;
using System.Text;

namespace vKitten.Interpreter.RuntimeTypes
{
    class ivKittenClass : ivKittenObject
    {
        public string classname;
        public ivKittenClass superclass;
        public List<ivKittenMethod> methodList;
        public ivKittenClass() : base()
        {
            methodList = new List<ivKittenMethod>();
        }
    }
}
