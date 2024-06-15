using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    class AbstractClass_Implementation
    {
        public static void MainAbs()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                Id = 101,
                FirstName = "Crsitboal",
                LastName = "BL",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("------------");
            ContractEmployee cte = new ContractEmployee()
            {
                Id = 101,
                FirstName = "Lio",
                LastName = "BL",
                HourlyPay = 30,
                TotalHrs = 160
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
