using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    class FirstClass
    {
        public void Display()   //Main class
        {
            System.Console.WriteLine("First Class");   //print msg
        }
    }
    class SecondClass : FirstClass     //Derived class inheriting from Main class
                                       //and hinding main class using inheritance
    {
        public new void Display()   //Main class
        {
            System.Console.WriteLine("Second Class");   //print msg
        }

    }

    internal class HidingMethod
    {
        public static void Main()
        {
            SecondClass obj = new SecondClass();      //Method
            obj.Display();

            Console.ReadKey();
        }
    }
    
   
}
