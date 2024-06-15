using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    interface IOne
    {
        void IMethod();
    }
    interface ITwo
    {
        void IMethod();
    }

    class Interface_Explicit : IOne, ITwo
    {
        //access modifiers are not allowed on explicity interfaces members
        //if you want to make one of the interface method as default, then implement it
        //normally and the other explicitly
        void IOne.IMethod()
        {
            Console.WriteLine("IOne method");
        }
        void ITwo.IMethod()
        {
            Console.WriteLine("ITwo method");
        }

        public static void MainInterface_Explicit()
        {
            //Interface_Explicit p = new Interface_Explicit();
            //p.IMethod();

            //((IOne)p).IMethod();
            //((ITwo)p).IMethod();

            IOne i1 = new Interface_Explicit();
            ITwo i2 = new Interface_Explicit();
            i1.IMethod();
            i2.IMethod();
        }
    }
}
