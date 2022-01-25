using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class PassParametersAndReturnMethod
    {
        public static void Main()
        //static "Access Specifier" void "Return Main() "Method Name"(Prameter List)
        {
            int num1 = 0, num2 = 0;
            //Accepting Values from users
            Console.WriteLine("Enter first number\t\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter second number\t\t");
            num2 = Convert.ToInt32(Console.ReadLine());


            PassParametersAndReturnMethod eOne=new PassParametersAndReturnMethod();
            int add = eOne.sum(num1, num2);
            Console.WriteLine("\n\nAddition\t\t{0}", add);       //Method body
            Console.ReadKey();
        }

        public int sum(int no1, int no2)
        //return    //parameters
        {
            int add = no1 + no2;      //Method of Addition
            return add;
        }
    }
}
