using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    public class CensoredWordCounter
    {
        // Task 3 - Part A


        public static int CensoredWordCount(String sentence)
        {
            Console.WriteLine("Your sentence is " + "\"" + sentence + "\"");
            Console.WriteLine(" ");

            string[] censorCount = { "dog", "cat", "large" };

            foreach (String word in censorCount)
            {
                Console.WriteLine("Censored word: " + word);
            }

            int counts = 0;
            int total = 0;

            Console.WriteLine("");

            foreach (String item in censorCount)
            {
                foreach (Match match in Regex.Matches(sentence, item))
                {
                    counts++;
                }

                Console.WriteLine("{0}" + " Found " + "{1}" + " Times", item, Regex.Matches(sentence, item).Count);
                total = total + Regex.Matches(sentence, item).Count;

            }

            Console.WriteLine(" ");
            Console.WriteLine("Total: " + total);
            return total;

        }
    }
}
