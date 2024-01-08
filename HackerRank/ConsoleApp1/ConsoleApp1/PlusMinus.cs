using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class PlusMinus
    {
        public static void Calculate(List<int> arr)
        {
            var positives = arr.Where(a => a > 0).ToList().Count;
            var negatives = arr.Where(a => a < 0).ToList().Count;
            var zeros = arr.Where(a => a == 0).ToList().Count;

            Console.WriteLine("{0:F6}", (double)positives/arr.Count);
            Console.WriteLine("{0:F6}", (double)negatives /arr.Count);
            Console.WriteLine("{0:F6}", (double)zeros /arr.Count);
        } 
    }
}
