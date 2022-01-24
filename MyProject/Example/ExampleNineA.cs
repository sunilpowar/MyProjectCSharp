using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleNineA
    {
        static void Main()
        {
            int num1, num2;
            //Accepting values from users
            Console.WriteLine("Enter First Number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second Number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());
            // || Logical Operator
            if (num1 < num2 || num1 == 20)  //Condition 1   
            {             //If one of the condition right then print this line  
                Console.WriteLine("\n\nNum1 is less than Num2 or Num1 is 20\t\t");
            }
            else
            {            //If both conditions fail then print this line
                Console.WriteLine("\n\nNum2 is Less than Num1\t\t");
            }
            Console.ReadKey();

        }


    }
}
