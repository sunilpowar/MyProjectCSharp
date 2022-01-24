using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    interface IMeter1   //Interface members are public  
    {
        void print1();
    }
    interface IMeter2
    {
        void print2();
    }
    class Meter : IMeter1, IMeter2  //class can inheriting from multiple Interfaces
    {
        public void print1()
        {
            Console.WriteLine("Print Meter 1");
        }
        public void print2()
        {
            Console.WriteLine("Print Meter 2");
        }
    }

    class InterfaceMethod
    {
        public static void Main()
        {
            Meter method = new Meter();      //Access the classes to define
            method.print1();
            method.print2();

            Console.ReadKey();
        }
    }
   
}
