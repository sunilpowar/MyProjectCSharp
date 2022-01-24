using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class Methods
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Students Marks");
            int marks = int.Parse(Console.ReadLine());

            switch (marks)
            {
                case 90:
                case 60:
                case 30:

                    Console.WriteLine("Need improvement {0}", marks);
                    break;
                default:     //if Entered no doesn't exist then prints default line 
                    Console.WriteLine("Please Enter valid value");
                    break;
            }

            Console.ReadKey();
        }
    }
}
