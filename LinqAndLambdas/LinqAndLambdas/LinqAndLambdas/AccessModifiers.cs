using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    public class Student
    {
        private int ID;
        public string _Name;
        protected string _Surnames;
    }

    public class CorporateStudent : Student
    {
        public void PrintInfo()
        {
            this._Name = "Cristobal";
            this._Surnames = "Buenrostro";
        }
    }
    public class OtherStudent
    {
        public void PrintInfo()
        {
            Student s = new Student();
            s._Name = "Lio";
        }
    }

    class AccessModifiers
    {
        public static void MainAccessModifiers()
        {

        }
    }
}
