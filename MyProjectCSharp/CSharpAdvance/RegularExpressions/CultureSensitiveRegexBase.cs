using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CSharpAdvance.RegularExpressions
{
    public class CultureSensitiveRegexBase
    {
        public static void Main()
        {
            //Define text to be parsed
            string input = "Office expences on 2/13/2008:\n" +
                           "Paper (500 sheets)                $3.95\n" +
                           "Pencils (box of 10)               $1.00\n" +
                           "Pens (box of 10)                  $4.49\n" +
                           "Erasers                           $2.19\n" +
                           "Ink jet Printer                   $69.95\n\n" +
                           "Total Expences                    $81.58\n";

            //Get current culture's NumberFormatInfo object.
            NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
            //Assign needed property values to variables.
            string currencySymbol = nfi.CurrencySymbol;
            bool symbolPrecedesIfPositive = nfi.CurrencyPositivePattern % 2 == 0;
            string groupSeparator = nfi.CurrencyGroupSeparator;
            string decimalSeparator = nfi.CurrencyDecimalSeparator;

            //Form regular expression pattern.
            string pattern = Regex.Escape(symbolPrecedesIfPositive ? currencySymbol : "") +
                             @"\s*[-+]?" + "([0-9]{0,3}(" + groupSeparator + "[0-9]{3})*(" +
                             Regex.Escape(decimalSeparator) + "[0-9]+)?)" +
                             (!symbolPrecedesIfPositive ? currencySymbol : "");
            Console.WriteLine("The Regular Expression Pattern is:");
            Console.WriteLine("   " + pattern);



            //Get text that matches regular exression pattern
            MatchCollection matches = Regex.Matches(input, pattern, RegexOptions.IgnorePatternWhitespace);
            Console.WriteLine("Found {0} matches.", matches.Count);

            //Get numeric string, convert it to a value, and add it to List object.
            List<decimal> expences = new List<Decimal>();

            foreach (Match match in matches)
                expences.Add(Decimal.Parse(match.Groups[1].Value));

            //Determine whether total is present and if present, whether it is correct.
            decimal total = 0;
            foreach (decimal value in expences)
                total += value;

            if (total / 2 == expences[expences.Count - 1])
                Console.WriteLine("The Expences total {0:C2}.", expences[expences.Count - 1]);
            else
                Console.WriteLine("The expences total {0:C2}.", total);

            Console.ReadKey();
        }
    }
}

//Output

//The Regular Expression Pattern is:  \$\s *[-+] ? ([0 - 9]{ 0,3} (,[0 - 9]{ 3})*(\.[0-9]+)?)
//Found 6 matches.
//The Expences total $81.58.