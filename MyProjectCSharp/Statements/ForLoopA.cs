using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectCSharp.Statements
{
    internal class ForLoopA
    {
        static void Main(string[] args)
        {
            Console.Write("How many attended today: ");
            int c = int.Parse(Console.ReadLine());
            string[] students = new string[c];

            for (int i = 0; i < c; i++)
            {
                Console.Write("Name of student: ");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("Attended to School today: ");

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.ReadKey();

        }
    }
}
