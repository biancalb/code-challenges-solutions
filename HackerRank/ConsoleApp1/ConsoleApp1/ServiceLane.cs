using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class ServiceLane
    {
        public static void CalculateMaximumSizes(int n, List<List<int>> cases, List<int> width)
        {
            var maxSizesPassAll = new List<int>();

            foreach (var c in cases)
            {
                var i = c[0];
                var j = c[1];
                var w = new List<int>();

                for (int index = i; index <= j; index++)
                {
                    w.Add(width[index]);
                }
                maxSizesPassAll.Add(w.Min());
            }

            Console.WriteLine(string.Join(' ', maxSizesPassAll));
        }
    }
}
