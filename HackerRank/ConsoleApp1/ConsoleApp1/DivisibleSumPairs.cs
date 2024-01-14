using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivisibleSumPairs
    {
        public static void CountPairs(int n, int k, List<int> ar)
        {
            var count = 0;
            var pairs = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (n - i <= 1) continue;

                Console.WriteLine($"i= {i}");
                for (int y = i + 1; y < n; y++)
                {
                    Console.WriteLine($"[{ar[i]},{ar[y]}]");
                    Console.WriteLine($"mod= {(ar[i] + ar[y]) % k}\n");

                    if ((ar[i] + ar[y]) % k == 0)
                    {
                        pairs.Add($"[{ar[i]},{ar[y]}]");
                        count++;
                    }
                }
                Console.WriteLine("------");

            }
            Console.WriteLine(string.Join(' ', pairs));
            Console.WriteLine("count= " + count);
        }
    }
}
