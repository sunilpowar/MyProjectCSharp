using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleTwelve
    {
        static void Main()
        {
            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int count = 1;   //Initial value of count is 1
            int count1 = 1;
            //While Loop checks the condition first and performs
            while (count <= num)    //Condition 1
                                    //giving output from 1 to taken count 
            {
                Console.WriteLine("While Number : {0} \n", count);
                count++;   // ++ adding 1 to previous number
                  //We are also using break; for breaking the loop with one outoput
            }
                //Do while Loop performs first and check the condition
            do
            {
                Console.WriteLine("Do while Number : {0} \n", count1);
                count1++;
            }
            while (count <= num);   //Condition 2

            Console.ReadKey();

        }
    }
}
