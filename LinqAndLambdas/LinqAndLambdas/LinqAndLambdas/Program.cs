using System;
using System.Linq;
using System.Collections;

namespace LinqAndLambdas
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            #region LINQ

            //LINQ.MainLINQ();

            #endregion

            #region 1 CAN YOU STORE DIFFERENT TYPES IN AN ARRAY? 

            //Arrays.Main();

            #endregion

            #region STATIC AND INSTANCE CLASS MEMBERS

            //StaticAndClassInstance.Main();

            #endregion

            #region JAGGED ARRAY

            //JaggedArray.Main();

            #endregion

            #region INTERFACES

            //Interfaces_declaration.Main();

            #endregion

            #region EXPLICIT INTERFACE IMPLEMENTATION

            //Interface_Explicit.Main();

            #endregion

            #region READONLY VS CONST

            //ReadOnly_Const.Main();

            #endregion

            #region IMPLEMENT ABSTRACT CLASS

            //AbstractClass_Implementation.Main();

            #endregion

            #region SINGLETON

            //Program_Singleton.Main();

            #endregion

            #region LINQ with objects

            //LINQ_obj.MainMethod();

            #endregion

            #region MULTIPLE CLASS INHERITANCE WITH INTERFACES
            //MultipleInheritance.MultipleInheritance_Main();
            #endregion

            #region Delegate

            //Delegate.Delegate_Main();
            //Delegate_Usage.Delegate_Usage_Main();


            #endregion

            #region C6
            //C6.MainC6();
            #endregion

            LambdaExp.LambdaEx();

            Console.ReadLine();
        }
    }

}