using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BirthdayCakeCandles
    {
        //Count how many candles are tallest.
        public static void CountTheTallest(List<int> candles)
        {
            var tallest = candles.GroupBy(x => x).OrderByDescending(x => x.Key).FirstOrDefault();
            Console.WriteLine(tallest.Count());
        }
    }
}
