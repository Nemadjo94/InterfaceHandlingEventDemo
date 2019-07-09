using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHandlingAnEvent
{
    /*
     * C# Program to IIlustrate Handling an Event Declared in an Interface
     */
    //This C# program is used to illustrate handling an event declared in an interface. Using classA and classB create 
    //the reference for the shape object as a square and Rectangle respectively.

    //Perform the shape procedure for square and rectangle, the lock statement is used to block a critical section by obtaining 
    //the mutual-exclusion lock for a given object, execute the statement, and then release the lock.

    //If condition statement is used for draw procedure to check the condition that handler variable value is not equal to null.
    //If the condition is true, then execute the statement and perform the handler() method.Here an event is handled with an interface.
    
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            ClassA sub = new ClassA(shape);
            ClassB sub2 = new ClassB(shape);
            shape.Draw();

            
        }
    }
}
