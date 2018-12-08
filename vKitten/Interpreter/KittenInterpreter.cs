using System;
using System.Collections.Generic;
using System.Text;
using vKitten.Interpreter.RuntimeTypes;

namespace vKitten.Interpreter
{
    class KittenInterpreter
    {
        public KittenInterpreter()
        {

        }

        public ivKittenObject Kitten_SendMessage(ivKittenObject obj, ivKittenMessage msg)
        {
            ivKittenClass cls = obj.isa;
            ivKittenMethod selectedMethod = null;
            //search methods up the inheritance tree
            while(true) {
                foreach (ivKittenMethod method in cls.methodList)
                {
                    if (method.methodName == msg.msg) selectedMethod = method;
                    goto end;
                }
                if (cls.superclass != cls) cls = cls.superclass; else goto end;
            }
            end:
            //can respond to message
            if (selectedMethod == null)
            {
                Kitten_ReportError($"Object Unable to Respond to message: {msg.ToString()}");
                return null;
            }
            //args count matches
            if (msg.args.Count != selectedMethod.argCount)
            {
                Kitten_ReportError("Argument count mismatch");
                return null;
            }
            //case 1: built-in functions
            if (selectedMethod is ivKittenBuiltinMethod)
            {
                selectedMethod.self = obj;
                return (selectedMethod as ivKittenBuiltinMethod).impl(msg.args);
            }
            //case 2: image functions
            else
            {
#warning implementation incomplete for image functions
                return null;
            }
            return null;
        }

        public ivKittenObject Kitten_AccessMember(ivKittenObject obj, string name)
        {
            ivKittenObject selectedMember = null;
            foreach (Tuple<string,ivKittenObject> t in obj.members)
            {
                if (t.Item1 == name) selectedMember = t.Item2;
            }
            //does have such member
            if (selectedMember == null)
            {
                Kitten_ReportError("object does not have such member");
                return null;
            }
            return selectedMember;
        }

        public void Kitten_ReportError(string error)
        {
#warning no impl for Kitten_ReportError
        }

    }
}
