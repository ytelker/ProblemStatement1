using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSpell
{
    /// <summary>
    /// Represents the class which handles Spell the number.
    /// </summary>
    public static class SpellNumber
    {
        /// <summary>
        /// Generates the spell from the given number sequence.
        /// </summary>
        /// <param name="number">Number to which spell needs to be generated.</param>
        /// <returns>Spell for the given number.</returns>
        public static string GetSpell(int number)
        {
            string numberSpell = string.Empty;

            char[] digits = number.ToString().ToCharArray();
            int length = digits.Length;

            if (length == 0)
            {
                return numberSpell = "Number not provided.";
            }

            string[] singleDigits = new string[]{  "zero", "one", "two",
                                                   "three", "four", "five",
                                                   "six", "seven", "eight",
                                                   "nine"};

            string[] doubleDigits = new string[]{"", "ten", "eleven", "twelve",
                                                   "thirteen", "fourteen",
                                                   "fifteen", "sixteen", "seventeen",
                                                   "eighteen", "nineteen"};

            string[] tensMultiple = new string[]{"", "", "twenty", "thirty",
                                                  "forty", "fifty","sixty",
                                                  "seventy", "eighty", "ninety"};

            string[] tensPower = new string[] { "hundred", "thousand" };

            if (length == 1)
            {
                return numberSpell = singleDigits[digits[0] - '0'];
            }


            return numberSpell;
        }
    }
}
