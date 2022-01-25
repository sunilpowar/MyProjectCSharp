using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleTwoA
    {
        public static void Main(string[] args)     //Starting of any Program
        {
            Console.WriteLine("Please Enter Name 1 ");  //use of Variable name for different Names 
            var name1 = Console.ReadLine();

            Console.WriteLine("Please Enter Name 2 ");
            var name2 = Console.ReadLine();

            Console.WriteLine("The Names Entered are {0} and {1} ", name1, name2);
            Console.ReadKey();
        }
    }
}
