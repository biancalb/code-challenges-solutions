using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class SalesbyMatch
    {
        public static void CountPairs(int n, List<int> ar)
        {
            int pairs = 0;

            foreach (var g in ar.GroupBy(p => p))
            {
                int resto = g.Count();
                while (resto > 1)
                {
                    pairs++;
                    resto -= 2;
                }
            }
            Console.WriteLine("pairs= " + pairs);
        }
    }
}
