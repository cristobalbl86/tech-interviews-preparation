using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract int GetMonthlySalary();
    }
}
