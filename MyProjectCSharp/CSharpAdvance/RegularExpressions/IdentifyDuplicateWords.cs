using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharpAdvance.RegularExpressions
{
    internal class IdentifyDuplicateWords
    {
        public static void Main()
        {
            string pattern = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a Dog.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))

                Console.WriteLine("{0} (Duplicates '{1}') at Postion {2}", match.Value, match.Groups[1].Value, match.Index);



            Console.ReadKey();
        }
    }
}

//Output:

//This this(Duplicates 'This') at Postion 0
//a a (Duplicates 'a') at Postion 66