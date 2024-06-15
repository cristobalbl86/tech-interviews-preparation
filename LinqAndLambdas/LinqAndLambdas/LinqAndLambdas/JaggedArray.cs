using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    class JaggedArray
    {
        public static void MainJaggedArray()
        {
            string[][] jaggedArray = new string[3][];
            string[] arrNames = new string[3];

            arrNames[0] = "Cristobal";
            arrNames[1] = "Lio";
            arrNames[2] = "Pungo";

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelor";
            jaggedArray[0][1] = "Master";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelor";

            jaggedArray[2][0] = "Master";
            jaggedArray[2][1] = "Doctorate";

            for (int a = 0; a < jaggedArray.Length; a++) 
            {
                string[] myarray = jaggedArray[a];
                Console.WriteLine(arrNames[a]);
                Console.WriteLine("-------------");
                for (int m = 0; m < myarray.Length; m++)
                {
                    Console.WriteLine(myarray[m]);
                }
                Console.WriteLine();
            }
        }
    }
}
