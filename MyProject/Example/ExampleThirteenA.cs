using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleThirteenA
    {
        static void Main()
        {

            string[] arr = new string[5];  //declaring Array= string

            arr[0] = "Abhi";
            arr[1] = "Karan";
            arr[2] = "Rohan";       //Values of Array
            arr[3] = "Prafull";
            arr[4] = "Amol";
            //foreach (Value of collection)
            foreach (string name in arr)  //in constant
            {
                Console.WriteLine("Hello " + name);
            }
            //for (initialization;  Condition; Increment;)
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("Value of a : {0}", arr[a]);
            }
            Console.ReadKey();
        }
    }
}
