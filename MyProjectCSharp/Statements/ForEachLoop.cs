using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ForEachLoop
    {
        public static void Main()
        {
            string[] myArray = new string[4];
            myArray[0] = "Name1";
            myArray[1] = "Name2";
            myArray[2] = "Name3";
            myArray[3] = "Name4";

            ArrayMethod("n1", "n2", "n3", "n4");
            Console.ReadKey();
        }

        public static void ArrayMethod(params string[] names)
                                      //using params to pass arrays to method
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Array size = {0}", names.Length);

        }
    }
}
