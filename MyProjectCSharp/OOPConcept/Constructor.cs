using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectCSharp.OOPConcept
{
    class Box
    {
        public double l, b, h;

        public double volume()
        {
            return (this.l * this.b * this.h);
        }
        public Box()
        {
            Console.WriteLine("The Constructor is Initialized");
            Console.ReadKey();
        }
    }

    internal class Constructor
    {
        public static void Main()
        {
            Box box = new Box();
        }
    }
}
