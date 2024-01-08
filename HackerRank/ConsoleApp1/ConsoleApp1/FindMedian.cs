using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class FindMedian
    {
        public static void Find(List<int> arr)
        {
            var arrOrdered = arr.OrderBy(x => x).ToList();
            if(arr.Count % 2 != 0)
            {
                var medianIndex = (int)Math.Ceiling((decimal)arr.Count / 2) - 1;
                Console.WriteLine(arrOrdered[medianIndex]);
            }
            else
            {
                var centerIndex = (int)Math.Ceiling((decimal)arr.Count / 2) - 1;
                var median = (double)(arrOrdered[(int)centerIndex] + arrOrdered[(int)centerIndex + 1]) / 2;
                Console.WriteLine(median);
            }
        }
    }
}
