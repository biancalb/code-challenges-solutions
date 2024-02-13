using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class BeautifulTriplets
    {
        public static void CountIsBeautiful(int d, List<int> arr)
        {
            var beautiful = new List<List<int>>();
            for (int i = 0; i < arr.Count; i++)
            {
                var current = arr[i];
                var indexes = new List<int> { i };

                for (int n = i + 1; n < arr.Count; n++)
                {
                    var diff = Math.Abs(current - arr[n]);
                    if (diff == d)
                    {
                        indexes.Add(n);
                        current = arr[n];
                    }
                    if (indexes.Count == 3) break;
                }
                if (indexes.Count == 3) beautiful.Add(indexes);
            }

            Console.WriteLine("total= " + beautiful.Count);
            Console.WriteLine("indexes= ");
            foreach (var item in beautiful)
            {
                Console.WriteLine(string.Join(',', item));
            }            
        }
    }
}
