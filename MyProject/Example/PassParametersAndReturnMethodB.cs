
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class PassParametersAndReturnMethodB
    {
        public static void Main()
        {
            int a = 15, b = 12;
            int sum = 0;
            int product = 0;
            MyCalc(a, b, out sum, out product);
                         //out for using return two values

            Console.WriteLine("Sum = {0} and Product ={1}", sum, product);

            Console.ReadKey();

        }
        public static void MyCalc(int x, int y, out int sum, out int prod)
        //Parameters   //out for using return two values
        {
            sum = x + y;
            prod = x * y;


        }

    }
}
