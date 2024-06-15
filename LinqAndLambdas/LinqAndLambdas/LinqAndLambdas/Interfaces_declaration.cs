using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{
    //contains declarations, not implementatios
    //by default all members are public
    //cannnot have fields/variables
    //interfaces cannot be instantiated
    interface ICustomer
    {
        void Print();
    }

    //an interface can inherits from another interface
    interface I2 : ICustomer
    {
        void I2Method();
    }

    //class can inherit from multiple interfaces, but cannot inherit from multiple classes
    class Client : I2 //ICustomer, I2
    {
        //if inherits from an Instance, the methods must be implemented
        //signature should match the declaration
        public void Print() //default implementation
        {
            Console.WriteLine("Interface print method");
        }
        public void I2Method()
        {
            Console.WriteLine("I2 method");
        }
    }
    
    class Interfaces_declaration
    {
        public static void MainInterfaces_declaration()
        {
            ///*
            
            Client c1 = new Client();
            c1.Print();
            c1.I2Method();

            //we cannot create an instance of an interface, 
            //ICustomer cust = new ICustomer();

            //but an interface reference variable can point to a derived class object
            ICustomer cust = new Client();
            cust.Print();
            
            //*/
        }
    }
}
