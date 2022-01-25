using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class SwitchCaseA
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Students Marks");
            int marks = int.Parse(Console.ReadLine());
            //Parse using for converting the string representation of a number

            switch (marks)   //Switching to next case if fails 
            {
                case 90:
                    Console.WriteLine("Excellent");
                    break;   // Breaking case statement
                case 60:
                    Console.WriteLine("Very Good");
                    break;
                case 30:
                    Console.WriteLine("Need Improvement");
                    break;
                default:     //if Entered no doesn't exist then prints default line 
                    Console.WriteLine("Please Enter valid value");
                    break;
            }
        }
    }
}
