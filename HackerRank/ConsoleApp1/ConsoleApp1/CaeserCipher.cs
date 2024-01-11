using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class CaeserCipher
    {
        public static void Encrypt(string s, int k)
        {
            var alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToList();
            var encrypted = new List<char>();

            foreach(var c in s)
            {
                if (!char.IsLetter(c))
                {
                    encrypted.Add(c);
                }
                else
                {
                    var isUpper = char.IsUpper(c);
                    var index = alphabet.IndexOf(isUpper ? c : char.ToUpperInvariant(c));

                    var rotationFactor = index + k;
                    int encryptedIndex = rotationFactor;

                    if(rotationFactor >= alphabet.Count)
                    {
                        encryptedIndex = rotationFactor % (alphabet.Count);
                    }

                    var newC = alphabet.ElementAt(encryptedIndex);
                    encrypted.Add(isUpper ? newC : char.ToLowerInvariant(newC));
                }
            }
            Console.WriteLine(string.Concat(encrypted));
            //var str = "cdefghijklmnopqrstuvwxyzab".Select(x => x).ToArray();            
            //var str = "1Y7U4WsDt23l4ww08E6zR3T19H4sWQ188N9bivyC6k1uNHAt1n10fz7fVk62XW2fyMU4D83am7R80N".Select(x => x).ToArray();
            //var str = "Lipps_Asvph!".Select(x => x).ToArray();
            //Console.WriteLine(string.Join(' ', str));
        }
    }
}
