using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    public class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHrs { get; set; }
        public override int GetMonthlySalary() 
        {
            return this.HourlyPay * this.TotalHrs;
        }
    }
}
