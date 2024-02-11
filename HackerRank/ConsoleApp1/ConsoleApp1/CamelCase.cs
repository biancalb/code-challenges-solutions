using System;
using System.Linq;

namespace ConsoleApp1
{
    public class CamelCase
    {
        public static void CountWords(string s)
        {
            Console.WriteLine(s.Count(c => c == Char.ToUpper(c)) + 1);
        }
    }
}
