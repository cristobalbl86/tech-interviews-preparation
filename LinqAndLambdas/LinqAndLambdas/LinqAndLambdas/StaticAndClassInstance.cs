using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambdas
{

    class StaticAndClassInstance
    {
        public static void MainStaticAndClassInstance()
        {
            Circle c1 = new Circle(5);
            float area1 = c1.CalcArea();
            Console.WriteLine("Area c1 = {0}", area1);

            Circle.Print();

            Circle c2 = new Circle(6);
            float area2 = c2.CalcArea();
            Console.WriteLine("Area c2 = {0}", area2);
        }
    }

    class Circle
    {
        static float _PI; // = 3.141f;
        int _Radius;

        static Circle() //used to initialize static members of the class, runs first than instance constructor
        {
            Console.WriteLine("Static constructor called!");
            Circle._PI = 3.141f;
        }
        //can be overloaded by the qty and type of parameters
        public Circle() : this(0)
        {
        }
        public Circle(int Radius)
        {
            Console.WriteLine("Instance constructor called!");
            this._Radius = Radius;
        }

        public float CalcArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }

        public static void Print()
        {
            Console.WriteLine("Printed");
        }

        //destructor
        ~Circle()
        {

        }
    }
}
