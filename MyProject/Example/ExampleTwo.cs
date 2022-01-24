using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class ExampleTwo
    {
        public static void Main(string[] args)     //Starting of any Program
        {
            Console.WriteLine("Please Enter Name 1 ");  //use of Variable name for different Names 
            var name1 = Console.ReadLine();

            Console.WriteLine("Please Enter Name 2 ");
            var name2 = Console.ReadLine();
           
            Console.WriteLine("The First Name is " + name1+" and Second name is " + name2 );
            Console.ReadKey();                  
        }
    }
}
