using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{

    public class Delegate_Usage
    {
        public static void Delegate_Usage_Main()
        {
            List<Empleado> listE = new List<Empleado>() {
                new Empleado(){ id = 10, Name = "Cristobal", Experience = 12 },
                new Empleado(){ id = 11, Name = "Vicente", Experience = 14 },
                new Empleado(){ id = 13, Name = "Angel", Experience = 4 },
                new Empleado(){ id = 14, Name = "Amado", Experience = 3 },
                new Empleado(){ id = 18, Name = "Felipe", Experience = 1}
            };

            //IsPromotedDelegate del = new IsPromotedDelegate(Promoted);
            //Empleado.PromoteEmployee(listE, del);

            Empleado.PromoteEmployee(listE, emp => emp.Experience >= 5);
        }

        public static bool Promoted(Empleado e)
        {
            if (e.Experience >= 5)
                return true;
            else
                return false;
        }
    }
    
    public delegate bool IsPromotedDelegate(Empleado emp);
    public class Empleado
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Empleado> lstEmp, IsPromotedDelegate isPromoted)
        {
            foreach (var emp in lstEmp)
            {
                if (isPromoted(emp))
                {
                    Console.WriteLine($"{emp.Name} promoted");
                }
            }            
        }
    }
}
