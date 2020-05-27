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

            int index = 0;
            while (index < digits.Length)
            {
                if (length >= 3)
                {
                    if (digits[index] - '0' != 0)
                    {
                        numberSpell += singleDigits[digits[index] - '0'] + " " + tensPower[length - 3] + " ";
                    }
                    --length;
                }
                else
                {
                    if (digits[index] - '0' == 1)
                    {
                        int sum = digits[index] - '0' + digits[index] - '0';
                        numberSpell += doubleDigits[sum];
                    }
                    else if (digits[index] - '0' == 2 && digits[index + 1] - '0' == 0)
                    {
                        numberSpell += "twenty";
                    }
                    else
                    {
                        int i = (digits[index] - '0');

                        if (i > 0)
                            numberSpell += tensMultiple[i] + " ";
                        else
                            numberSpell += "";

                        ++index;
                        if (digits[index] - '0' != 0)
                            numberSpell += singleDigits[digits[index] - '0'];
                    }
                }
                ++index;
            }

            return numberSpell;
        }
    }
}
