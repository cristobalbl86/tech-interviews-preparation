using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas.Cognizant
{
    public class A
    {
        public virtual string add() { return "Add from A"; }
        public virtual string delete() { return "delete from A"; }
    }
    public class B : A
    {
        public override string add()
        {
            return "Add from B"; 
        }
        public string modify() { return "I am modify method"; }
    }

    public class Interview {
        public static void Main(object[] args) {
            A a = new B();

            GetValue(new B());
        }

        public static string GetValue<T>(T t)
            where T : A
        {
            return t.add();
        }
    }
}
