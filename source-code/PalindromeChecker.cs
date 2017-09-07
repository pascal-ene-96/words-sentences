using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    public class PalindromeChecker
    {

        // Task 2 - Palindrome Check 

        public static bool PalindromeCheck(String value)
        {
            Console.WriteLine("Enter your sentence:");
            Console.WriteLine(" ");


            Console.WriteLine("\"" + value + "\"" + " is your sentence.");
            Console.WriteLine(" ");

            value = value.Trim();
            value = value.Replace(" ", "");
            value = value.Replace("'", "");
            int min = 0;
            int max = value.Length - 1;

            while (true)
            {
                if (min > max)
                {
                    Console.WriteLine("true");
                    Console.WriteLine(" ");
                    Console.WriteLine("It is a palindrome.");
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    Console.WriteLine("false");
                    Console.WriteLine(" ");
                    Console.WriteLine("It is not a palindrome.");
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
