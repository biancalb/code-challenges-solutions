using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstReverse
    {
        // return the string in reversed order
        public static void Reverse(string str)
        {
            Console.WriteLine(ReversedOrder(str));
        }

        public static string ReversedOrder(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }
    }
}
