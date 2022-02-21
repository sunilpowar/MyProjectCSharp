using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example

{
    internal class PassByReference
    {
        public static void Main()
        {
            int y = 0;
            MyFunc(ref y);   //passing the values by refernce of x value

            Console.WriteLine("x = y = {0}", y);

            Console.ReadKey();

        }
        public static void MyFunc(ref int x)    //pass to y using ref 
        {
            x = 10;
        }

    }
}
