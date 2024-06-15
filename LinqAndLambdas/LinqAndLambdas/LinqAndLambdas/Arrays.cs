using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LinqAndLambdas
{
    class Arrays
    {

        public static void MainArrays()
        {
            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = "string";

            object[] arrayo = new object[3];
            arrayo[0] = 1;
            arrayo[1] = "string";

            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Cristo";
            arrayo[2] = c;

            //ARRAY LIST
            ArrayList arrl = new ArrayList();
            arrl.Add(1);
            arrl.Add("string");
            arrl.Add(c);

            foreach (object obj in arrl)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
