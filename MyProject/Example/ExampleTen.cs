using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleTen
    {
        static void Main()
        {        //myArray is a variable
            string[] myArray = new string[4];   //value of Array is 4
            myArray[0] = "Prafull";    
            myArray[1] = "Karan";
            myArray[2] = "Rohan";
            myArray[3] = "Abhi";

            Console.WriteLine(myArray[3]);

            Console.ReadKey();
        }

    }
}
