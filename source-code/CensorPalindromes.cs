using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Words
{
    public class CensorPalindromes
    {
        // Task 4 - Part C

        public static bool CensoringPalindromes(String w2)
        {
            Console.WriteLine("Original sentence:");
            Console.WriteLine(" ");
            Console.WriteLine(w2);

            w2 = w2.ToLower();
            string[] words = w2.Split(' ');
            List<string> finalWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var item = words[i];
                item = item.Trim();
                item = item.Replace(" ", "");

                int min = 0;
                int max = item.Length - 1;
                if (true)
                {
                    char a = item[min];
                    char b = item[max];
                    if (char.ToLower(a) != char.ToLower(b))
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
                    min++;
                    max--;
                }

            }

            Console.WriteLine(" ");
            Console.WriteLine("Censored sentence:");
            Console.WriteLine(" ");

            foreach (String item in finalWords)
            {
                Console.Write(item + " ");
            }


            return true;
        }
    }
}
