using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class PassParametersAndReturnMethodA
    {
        public static void Main()
        {
            int a = 54, b = 72;
            MyCalc(a, b);    //Variables


            Console.WriteLine(MyCalc(a, b));

            Console.ReadKey();

        }
        public static int MyCalc(int x, int y)
                                  //Parameters
        {                            
            int add = x + y;
            return add;
        }
    }
}
