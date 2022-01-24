using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    interface Meter1   //Interface members are public  
    {
        void print();         //method 1
    }
    interface Meter2
    {
        void print();         //method2
    }
    class InterfaceExplicit : Meter1, Meter2  //class can inheriting from multiple Interfaces
    {
        void Meter1.print()
        {
            Console.WriteLine("Print Meter 1");
        }
        void Meter2.print()                    //Mrhod of two same interfaces Methods explicit data 
        {
            Console.WriteLine("Print Meter 2");
        }
        public static void Main()
        {
            InterfaceExplicit ex = new InterfaceExplicit();      //Access the classes to define
            ((Meter1)ex).print();
            ((Meter2)ex).print();
            Console.ReadKey();
        }
    }
}
