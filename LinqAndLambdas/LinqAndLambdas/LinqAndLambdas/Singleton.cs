using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstance 
        { 
            get {
                if (instance == null) {
                    instance = new Singleton();
                }
                return instance;
            } 
        }
        public Singleton()
        {
            counter++;
            Console.WriteLine("counter: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Program_Singleton
    {
        public static void MainProgram_Singleton()
        {
            Singleton s = Singleton.GetInstance;
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;
        }
    }
}
