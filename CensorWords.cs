using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    public class CensorWords
    {
        // Task 3 - Part B

        public static void CensoringWords(String w1)
        {
            Console.WriteLine("Original sentence:");
            Console.WriteLine(" ");
            Console.WriteLine(w1);
            Console.WriteLine(" ");

            string[] censorWords = { "meow", "woof." };
            w1 = w1.ToLower();
            string[] words = w1.Split(' ');


            List<string> finalWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var item = words[i];
                item = item.Trim();
                item = item.Replace(" ", "");

                if (true)
                {
                    if (item != censorWords[0] && item != censorWords[1])
                    {
                        finalWords.Add(item);
                    }
                    else
                    {
                        String result;
                        result = Regex.Replace(item, item, m => new String('$', m.Length));
                        item = result;
                        finalWords.Add(item);
                    }
                }
            }

            foreach (String word in censorWords)
            {
                Console.WriteLine("Censored word: " + word);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Censored sentence:");
            Console.WriteLine(" ");

            foreach (String item in finalWords)
            {
                Console.Write(item + " ");
            }

        }
    }
}
