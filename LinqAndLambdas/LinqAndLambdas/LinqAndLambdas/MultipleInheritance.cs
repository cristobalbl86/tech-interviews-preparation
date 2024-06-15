using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    interface IA 
    {
        void Amethod();
    }
    interface IB
    {
        void Bmethod();
    }
    class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A method");
        }
    }
    class B : IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B method");
        }
    }
    class C : IA, IB
    {
        A a = new A();
        B b = new B();
        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }
    public class MultipleInheritance
    {
        public static void MultipleInheritance_Main()
        {
            C c = new C();
            c.Amethod();
            c.Bmethod();
        }
    }
}
