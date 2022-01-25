using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    public abstract class MeterA   //Abstract classes can be used as base class
                                  // cannot be used as normal class
    {

        public abstract void printMeter1();    //Access Modifier 
                                               //Abstract class have no any defination
        public void printMeter2()     //normal class with defination
        {
            Console.WriteLine("We are in Meter print 2");
        }
    }

    class AbstractClass : MeterA      //inheriting from abstract class 
    {
        public override void printMeter1()     //Method of abstract class
        {
            Console.WriteLine("We are in Meter print 1");
        }

        public static void Main()
        {
            AbstractClass ex1 = new AbstractClass();     //Access the classes to define
            ex1.printMeter1();
            ex1.printMeter2();
            Console.ReadKey();
        }
    }
    
}
