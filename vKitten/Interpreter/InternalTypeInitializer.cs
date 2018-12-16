using System;
using System.Collections.Generic;
using System.Text;
using vKitten.Interpreter.RuntimeTypes;

namespace vKitten.Interpreter
{
    class InternalTypeInitializer
    {
        public ivKittenClass kObject_meta_cls;
        public ivKittenClass kObject_cls;
        public ivKittenClass kString_meta_cls;
        public ivKittenClass kString_cls;

        public List<ivKittenClass> init()
        {
            List<ivKittenClass> standardImage = new List<ivKittenClass>();
            //kObject_metaclass (no implementation yet)
            kObject_meta_cls = new ivKittenClass() { classname = "meta_kObject"};

            //kObject
            ivKittenClass kObject_cls = new ivKittenClass();
            kObject_cls.classname = "kObject";
            kObject_cls.isa = kObject_meta_cls;
            kObject_cls.superclass = kObject_cls; //superclass of Object is itself
            

            //KObject_metaclass finish-up
            kObject_meta_cls.superclass = kObject_cls;
            kObject_meta_cls.isa = kObject_meta_cls;

            //kString_metaclass (no implementation yet)
            ivKittenClass kString_meta_cls = new ivKittenClass() {classname = "meta_kString", isa = kObject_meta_cls, superclass = kObject_meta_cls };
            //kString
            ivKittenClass kString_cls = new ivKittenClass() {classname = "kString",isa = kObject_meta_cls,superclass = kObject_cls };


            /*kObject member methods*/
            //kObject_toString
            var kObject_toString_method = new ivKittenBuiltinMethod() { methodName = "toString", argCount = 0 };
            kObject_toString_method.impl = n =>
            {
                return new ivKittenString("this is returned by sending toString to Object");
            };

           

            return standardImage;
        }
    }
}
