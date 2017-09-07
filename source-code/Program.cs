using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ");
            Console.WriteLine("Enter a number to run a method");
            Console.WriteLine(" ");
            Console.WriteLine("1. Letter Occurrence Counter");
            Console.WriteLine("2. Palindrome Checker");
            Console.WriteLine("3. Censored Word Occurence Counter");
            Console.WriteLine("4. Censoring Words in a Sentence");
            Console.WriteLine("5. Censoring Palindromes in a Sentence");
            Console.WriteLine(" ");


            int caseSwitch;


            switch (caseSwitch = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    // Task 1 - Letter Count
                    Console.WriteLine(" ");
                    String sentence = "I have some cheese";
                    char letter = Convert.ToChar("e");
                    LetterCounter.LetterCount(sentence, letter);
                    Console.WriteLine(" ");
                    break;
                case 2:
                    // Task 2 - Palindrome Check
                    Console.WriteLine(" ");
                    String value = "I have some cheese";
                    PalindromeChecker.PalindromeCheck(value);
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    break;
                case 3:
                    // Task 3 - Part A
                    Console.WriteLine(" ");
                    CensoredWordCounter.CensoredWordCount("I have a cat named Meow and a dog named Woof. I love the dog a lot. He is larger than a small horse.");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    break;
                case 4:
                    // Task 3 - Part B
                    Console.WriteLine(" ");
                    CensorWords.CensoringWords("I have a cat named Meow and a dog named Woof. I love the dog a lot. He is larger than a small horse.");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    break;
                case 5:
                    // Task 3 - Part C
                    Console.WriteLine(" ");
                    CensorPalindromes.CensoringPalindromes("Anna went to vote in the election to fulfil her civic duty");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
