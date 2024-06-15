using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    public delegate void MyDelegate(string message);
    class Delegate
    {
        public static void Delegate_Main()
        {
            MyDelegate del = new MyDelegate(PrintMessage);
            del("Delegate test");
        }

        public static void PrintMessage(string strMsg)
        {
            Console.WriteLine(strMsg);
        }
    }
}
