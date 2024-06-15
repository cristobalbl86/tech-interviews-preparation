using System;

namespace LinqAndLambdas
{
    public class C6
    {
        //Auto-property initializaers
        public int myintvalue { get; set; } = 6;
        public string mystrvalue { get; set; } = "my default prop value :O";

        //Expression bodied Properties
        public string FullProp => mystrvalue + " " + myintvalue.ToString();

        public static void MainC6()
        {
            //using static
            Console.WriteLine("C#6: using writeline directly.");

            //null conditional operator
            string mystr = "C#6: Has a value";
            mystr = null;
            
            //WriteLine(mystr?.ToString() ?? "C#6: It is null");
            
            //WriteLine($"Return of sum is: {}")
            
            //ReadLine();
         }

        //Expression bodied methods
        //public int ReturnSum(int a, int b) => a + b;

        public int GetSum2(int a, int b)
        {
            return a + b;
        }
    }
}
