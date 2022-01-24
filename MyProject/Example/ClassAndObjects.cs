using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    class Box   //Box is a class
    {
        public double l, b, h;   //Member variables
        public double volume(double l, double b, double h)
        //Name of Method   //Parameters
        {
            return (l * b * h);  //Return value Formula
        }

        internal class ClassAndObjectcs   //Main class
        {
            public static void Main()
            {
                Box box1 = new Box();    //box1 is a object
                box1.l = 15;
                box1.b = 10;      //Assign the Values
                box1.h = 20;

                Console.WriteLine("Volume of box1 is {0}", box1.volume(box1.l, box1.b, box1.h));

                Console.ReadKey();
            }
        }

    }
    
}


