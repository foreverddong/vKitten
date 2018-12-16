## The Structure of vKitten


The kitten language will generally be designed into a dynamic-typed smalltalk-like language.

#### at the current stage, this project will be consisted with 2 components

1. vKitten Interpreter (combined with a runtime)

2. Bytecode Compiler 


Interpreter will be a stack-based(or not) virtual machine that reads bytecodes and execute them in the runtime

**runtime**

at the basic level, everything would be objects. Objects interact with each other by sending messages. Objects also perform specific actions by reacting to messages.

there are several built-in classes to begin with, namely:

+ *kObject* (and the metaclass *meta_kObject*)
  * -> *kInteger* (and the metaclass *meta_kInteger*)
  * -> *kFloat* (and the metaclass *meta_kFloat*)
  * -> *kBoolean* (and the metaclass *meta_kBoolean*)
  * -> *kString* (and the metaclass *meta_kString*)

the isa (is-a) member in each Object indicates what class it belongs, and the superclass member in each class indicates its superclass, for example:

an Object **sampleInteger** is-a ***kInteger***.

the superclass of ***kInteger*** is ***kObject***.

the class ***kInteger*** is-a ***meta_kInteger***

the superclass of ***kObject*** is ***kObject*** (itself)

the class ***kObject*** is-a ***meta_kObject***

