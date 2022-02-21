using System;
using System.Text.RegularExpressions;

namespace CSharpAdvance.RegularExpressions
{
    internal class ReplaceString
    {
        static void Main(string[] args)
        {
            string str = "Hi,welcome@JavaTPoint.com";

            string result = Regex.Replace(str, "[^a-zA-Z0-9_]+", " ");

            Console.Write("{0} ", result);

            Console.ReadLine();
        }
    }
}

//Output:

 //Hi welcome JavaTPoint com