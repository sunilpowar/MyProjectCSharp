using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    //Delegates is a type which holds the methods reference in an object.
    //It is also referred to as a type safe function pointer.

    public delegate int addNumbersDelegate(int number1, int number2);
    //Arguments
    class Delegates
    {
        public static int addNumbers(int number1, int number2)
        //Parameters
        {
            return number1 + number2;
        }
        public static void Main()
        {
            addNumbersDelegate del = new addNumbersDelegate(addNumbers);    //Access the classes to define
            int result = del(66478, 83255);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
