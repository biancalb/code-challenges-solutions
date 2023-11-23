using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LetterChanges
    {
        public static void ReplaceLetters(string str)
        {
            // code goes here  
            string[] vowels = { "a", "e", "i", "o", "u" };

            string[] alphabetArray = {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            string modifiedString = string.Empty;
            int letterZIndex = Array.IndexOf(alphabetArray, "Z");

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    //replace to the following
                    int index = Array.IndexOf(alphabetArray, c.ToString().ToLowerInvariant());

                    string f = letterZIndex == index ? alphabetArray[0] : alphabetArray[index + 1];

                    //Capitalize vowel
                    if (vowels.Contains(f)) f = f.ToUpperInvariant();

                    modifiedString += f;
                }
                else
                {
                    modifiedString += c;
                }

            }

            //return modifiedString;
            Console.WriteLine(modifiedString);
        }
    }
}
