using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LongestWord
    {
        public static void Find(string sen)
        {
            string[] words = sen.Split(' ', StringSplitOptions.None);
            string longestWord = string.Empty;

            foreach(string word in words)
            {
                bool checkPunctuation = word.All(w => Char.IsLetterOrDigit(w));
                
                if(word.Length > longestWord.Length && checkPunctuation)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
