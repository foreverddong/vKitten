using System;
using System.Collections.Generic;
using System.Text;
using vKitten.Interpreter.RuntimeTypes;

namespace vKitten.Interpreter
{
    class InternalTypeInitializer
    {
        public static List<ivKittenClass> init()
        {
            List<ivKittenClass> standardImage = new List<ivKittenClass>();
            //kObject_metaclass (no implementation yet)
            ivKittenClass kObject_cls_meta = new ivKittenClass();


            //kObject
            ivKittenClass kObject_cls = new ivKittenClass();
            kObject_cls.classname = "kObject";
            kObject_cls.isa = kObject_cls_meta;
            kObject_cls.superclass = kObject_cls; //superclass of Object is itself
            //kObject_toString
            var kObject_toString_method = new ivKittenBuiltinMethod() {  };

        }
    }
}
