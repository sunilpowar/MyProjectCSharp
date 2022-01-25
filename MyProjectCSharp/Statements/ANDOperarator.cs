using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ANDOperarator
    {
        static void Main()
        {
            int num1, num2;
            //Accepting values from users
            Console.WriteLine("Enter First Number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second Number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());
            //&& Logical Operator
            if (num1 < num2 && num1 == 50)  //Condition 1   
            {             //If both conditions right then print this line  
                Console.WriteLine("\n\nNum1 is less than Num2 and Num1 is 50\t\t");
            }
            else 
            {            //If both conditions fail then print this line
                Console.WriteLine("\n\nNum2 is Less than Num1\t\t");
            }
            Console.ReadKey();

        }
    }
}
