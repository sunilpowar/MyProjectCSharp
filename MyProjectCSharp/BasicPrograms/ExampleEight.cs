using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectCSharp.BasicPrograms
{
    internal class ExampleEight
    {

        static void Main(string[] args)
        {
            int x = 2;
            string y = null;    //null means it does not contain any value
            DoMath(out x, out y);
            Console.WriteLine("I have" + x + " " + y);
            Console.ReadKey();
        }

        static void DoMath(out int a, out string b)
        {
            int v = 15;
            a = v + 10;
            b = "friends";
        }

    }
}
