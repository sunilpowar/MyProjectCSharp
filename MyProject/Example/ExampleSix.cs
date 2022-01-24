using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    internal class ExampleSix
    {
        static void Main()
        {
            string path = "C:\\Users\\Shree\\SourabhPowar\\Shell_Tutorials"; 
            Console.WriteLine(path);    //using \\ for priting path


            //Verbatim string literals @
            string path1 = @"C:\Users\Shree\SourabhPowar\Shell_Tutorials";
            Console.WriteLine(path1);    //using @ for priting path
            Console.ReadKey();

        }
    }
}
