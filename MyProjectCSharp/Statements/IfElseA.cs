using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class IfElseA
    {
        static void Main()
        {
            int num1, num2;
            //Accepting values from users
            Console.WriteLine("Enter First Number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

                 //Comparison Operator
            if (num1 > num2)   //Condition 1
            {
                Console.WriteLine("\n\nNum1 is greater than Num2\t\t");  
            }
            else if (num1 == num2)    //Condition 2
            {
                Console.WriteLine("\n\nNum1 is Equal to Num2\t\t");
            }
            else     //if both Conditions fails then print this line
            {
                Console.WriteLine("\n\nNum2 is greater than Num1\t\t");
            }
            Console.ReadKey();
        }
    }
}
