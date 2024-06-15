using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class TPL
    {

        public void MainTPL (){

            Task<string> t1 = new Task<string>(() => DoWork(1, 2000));      
            t1.Start();
            Console.WriteLine(t1.Result);

            Task t2 = new Task(() => DoWork(2, 1000))
                .ContinueWith((prev) => DoWork(4, 1000));
            t2.Start();

            Task t3 = new Task(() => DoWork(3, 3000));
            t3.Start();

        }

        public static string DoWork(int i, int sleep) {

            Console.WriteLine($"Task {i.ToString()} is beggining");
            Thread.Sleep(sleep);
            return $"Task {i.ToString()} is completed";

        }

        public static void DoSomethingElse(int i, int sleep)
        {

            Console.WriteLine($"Other Task {i.ToString()} is beggining");
            Thread.Sleep(sleep);
            Console.WriteLine($"Other Task {i.ToString()} is completed");

        }


    }
}
