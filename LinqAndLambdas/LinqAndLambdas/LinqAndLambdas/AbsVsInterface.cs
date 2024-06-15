using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    //can inherits from other abs classes
    //can have abstract methods, or not
    public abstract class AbsClass
    {
        int id;
        public void Print()
        {
            Console.WriteLine("Printed from abs");
        }
    }

    //cannot have member implementation
    //cannot have access modifiers
    //cannot have fields
    //can inherits from other interfaces, but not from abs classes
    public interface IvsAbs
    {
        void Print();
    }

    //class can inherit from a single class, one abs class, or multiple Interfaces
    public class AbsVsInterface
    {

    }
}
