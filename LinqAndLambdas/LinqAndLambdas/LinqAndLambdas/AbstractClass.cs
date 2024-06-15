using System;
using System.Collections.Generic;
using System.Text;

namespace OtherClasses
{
    //cannot be isntantiated, but can be inherited
    //can only be used as base class
    //abstract class cannot be sealed
    /// <summary>
    /// may contain abstract members, but not mandatory
    /// </summary>
    public abstract class Customer
    {
        public abstract void Print();

        public void Print2()
        {
            Console.WriteLine("Print method no abstract executed");
        }
    }

    //non abstract class derived from abstract class must implement all inherited abstract methods
    public class AbstractClass : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print method executed");
        }

        public static void Main2()
        {
            Customer c = new AbstractClass();
            c.Print();

            c.Print2();
        }
    }
}
