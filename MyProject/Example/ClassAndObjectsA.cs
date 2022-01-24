using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    class BoxA   //Box is a class
    {
        public double l, b, h;   //Member variables
        public double volume()
        //Name of Method   //Parameters
        {
            return (this.l * this.b * this.h);   //Return value Formula
        }


        internal class ExampleFour    //Main class
        {
            public static void Main()
            {
                BoxA box1 = new BoxA();    //box1 is a object
                box1.l = 40;
                box1.b = 25;    //Assign the Values
                box1.h = 65;

                Console.WriteLine("Volume of box1 is {0}", box1.volume());

                BoxA box2 = new BoxA();    //box2 is a another object
                box2.l = 24;
                box2.b = 14;    //Assign the Values
                box2.h = 18;

                Console.WriteLine("\n\nVolume of box2 is\t\t{0}", box2.volume());


                Console.ReadKey();
            }
        }
    }

}


