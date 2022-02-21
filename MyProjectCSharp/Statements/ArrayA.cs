using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectCSharp.Statements
{
    internal class ArrayA
    {
        static void Main(string[] args)
        {
            int elements = 5;
            double[] numbers = new double[elements];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            Console.ReadKey();
        }
    }
}
