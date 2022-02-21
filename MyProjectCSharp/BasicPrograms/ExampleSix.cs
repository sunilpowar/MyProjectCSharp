using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectCSharp.BasicPrograms
{
    internal class ExampleSix
    {
         static void Main(string[] args)
         {
              int a = 123;
              string sentence = "a equals" + a.ToString();   
              Console.WriteLine(sentence);
              Console.ReadKey();

         }
                  //a eaquls123
                  //a.ToString is usimg for convert any type of data to string
                  //convert variable, integer, decimal, character,etc.
    }
}
