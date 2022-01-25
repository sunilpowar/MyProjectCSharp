using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class OverloadingMethod
    {
        public static void Main()
        {
            Console.WriteLine("Sum of two ints is {0}", sum(54, 56));
            Console.WriteLine("Sum of two Double is {0}", sum(57, 58));
            Console.ReadKey();
        }

        public static int sum(int x, int y)
        {
            int add = x + y;          //method of Addition
            return add;

        }
        public static double sum(double x, double y)
        {
            double add = x + y;      //method of Addition using Double for prints multiole values 
            return add;

        }
    }
}
