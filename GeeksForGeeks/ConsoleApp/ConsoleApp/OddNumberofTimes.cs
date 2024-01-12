using System;
using System.Linq;

namespace ConsoleApp
{
    public class OddNumberofTimes
    {
        public static void FindNumber(int[] arr)
        {
            Console.WriteLine("arr= " + string.Join(' ', arr));
            var ocurrsOddTimes = arr.GroupBy(x => x).Where(g => g.Count() % 2 != 0).Select(c => c.Key).FirstOrDefault();
            Console.WriteLine(ocurrsOddTimes);
        }
    }
}
