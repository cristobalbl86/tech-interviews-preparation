using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    class ReadOnly_Const
    {
        public const string myConst = "const value";
        public readonly string myReadOnlyVar;

        public ReadOnly_Const(string ROValue)
        {
            myReadOnlyVar = ROValue;
        }

        public static void MainReadOnly_Const()
        {
            //const is static and belongs to the class, not the instance
            Console.WriteLine(ReadOnly_Const.myConst);

            //readonly, must be instantiated to have access to it
            ReadOnly_Const p = new ReadOnly_Const("set read only value");
            Console.WriteLine(p.myReadOnlyVar);
        }
    }
}
