using System;
using System.Collections.Generic;
using System.Text;

#warning "ivKittenFunction does not have implementation"

namespace vKitten.Interpreter.RuntimeTypes
{
    abstract class ivKittenMethod
    {
        public string methodName;
        public int argCount = 0;
        public ivKittenObject self;
    }

    class ivKittenRuntimeMethod : ivKittenMethod
    {
        
    }

    class ivKittenBuiltinMethod : ivKittenMethod
    {
        public Func<List<ivKittenObject>, ivKittenObject> impl;
    }
}

