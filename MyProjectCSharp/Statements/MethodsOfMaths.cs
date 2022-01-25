using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class MethodsOfMaths
    {
        static void Main()
        {    
            int num1, num2;          //int = initial value
            int add, sub, mul, rem;   // + - * %
            float div;           // float is using for Division

                //Accepting Values from users
            Console.WriteLine("Enter First Number\t\t");   // \t using for space between lines vertically
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second Number\t\t");  // \n using for space between lines horizontally
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;  //adding Values
             
            sub = num1 - num2;   //subracting values

            mul = num1 * num2;   //multipliying values

            div = (float)num1 / num2;   //dividing values
                 //float using for answering in decimals
            rem = num1 % num2;    //Remainder

            //Displaying Output
            Console.WriteLine("Addition\t\t{0}", add);
            Console.WriteLine("Subtaction\t\t{0}", sub);
            Console.WriteLine("Multiplication\t\t{0}", mul);
            Console.WriteLine("Division\t\t{0}", div);
            Console.WriteLine("Remainder\t\t{0}", rem);         

            Console.ReadKey();
        }
    }
}
