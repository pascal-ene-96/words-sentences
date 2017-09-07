using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    public class LetterCounter
    {

        // Task 1 - Letter Count

        public static int LetterCount(String sentence, char letter)
        {
            Console.WriteLine("Your sentence is " + "\"" + sentence + "\"");
            Console.WriteLine(" ");

            Console.WriteLine("The letter you want to count is " + "\"" + letter + "\"");
            Console.WriteLine(" ");

            int count = 0;

            foreach (char c in sentence)
            {
                if (c == letter) count++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Letter Count: " + count);
            Console.ReadLine();
            return count;
        }
    }
}
