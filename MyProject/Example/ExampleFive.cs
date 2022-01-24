using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleFive
    {
        static void Main()
        {
            string name = "\"This is a Name\"";   // "This is a Name"
            Console.WriteLine(name);               // lines shows in Double codes using escape sequence

            string name1 = @"""This is Name""";    //using @ And Triple codes
            Console.WriteLine(name1);

            string line = "This \n is\n a\n Name";
            Console.WriteLine(line);               //Using \n ouput
            Console.ReadKey();                     //This
                                                   //is 
                                                   //a
                                                   //name

        }

    }
}
