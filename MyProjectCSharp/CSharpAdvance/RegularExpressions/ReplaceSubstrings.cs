using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharpAdvance
{
    internal class ReplaceSubstrings
    {
        public static void Main()
        {
            string pattern = "(Mr.\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Mrs. Abraham Adams", "Ms. Nicole Norris" };

            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            Console.ReadKey();


        }
    }
}

//Output:

//Henry Hunt
//Sara Samuels
//Abraham Adams
//Nicole Norris
