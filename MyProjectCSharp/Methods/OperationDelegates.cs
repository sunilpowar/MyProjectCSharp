using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    //Delegates is a type which holds the methods reference in an object.
    //It is also referred to as a type safe function pointer.

    public delegate int operationDelegate(int number1, int number2);
                                            //Arguments
    class OperationDelegates
    {
        public static int addNumbers(int number1, int number2)
                                        //Parameters
        {
            return number1 + number2;
        }
        public static int subsNumbers(int number1, int number2)
                                       //Parameters
        {
            return number1 + number2;
        }
        public static int productNumbers(int number1, int number2)
                                            //Parameters
        {
            return number1 + number2;
        }
        public static void Main()        //operationDelegate is using for multiple methods
        {
            operationDelegate del1 = new operationDelegate(addNumbers);    //Access the classes to define
            int result1 = del1(895, 324);
            Console.WriteLine("Additon= " + result1);

            operationDelegate del2 = new operationDelegate(subsNumbers);    //Access the classes to define
            int result2 = del2(956, 885);
            Console.WriteLine("Substraction= " + result2);

            operationDelegate del3 = new operationDelegate(productNumbers);    //Access the classes to define
            int result3 = del3(64, 98);
            Console.WriteLine("Product=" + result3);

            Console.ReadKey();
        }
    }
}
