using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class MarsExploration
    {
        public static void CountChangedLetters(string s)
        {
            Dictionary<int, char> ch = new Dictionary<int, char>()
            {
                {0, 'S'},
                {1, 'O'},
                {2, 'S'}
            };

            var changedLetters = 0;
            var msg = "";

            for (int i = 0; i < s.Length; i++)
            {
                msg += s[i];
                if (msg.Length == 3)
                {
                    Console.WriteLine("msg= " + msg);
                    foreach (KeyValuePair<int, char> c in ch)
                    {
                        if (msg[c.Key] != c.Value) changedLetters++;
                    }
                    msg = "";
                }
            }
            Console.WriteLine("changedLetters= " + changedLetters);
        }
    }
}
