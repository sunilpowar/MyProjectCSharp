using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class MethodAddition
    {
        public static void Main()
            //static "Access Specifier" void "Return Main() "Method Name"(Parameter List)
        {
            MethodAddition eOne = new MethodAddition();
            eOne.sum();                      //Method body
            Console.ReadKey();
        }

        public void sum()
        {
            int no1 = 654, no2 = 564;       //Method of Addition
            int add = no1 + no2;
            Console.WriteLine("Addition\t\t{0}", add);
        }
    }
}
