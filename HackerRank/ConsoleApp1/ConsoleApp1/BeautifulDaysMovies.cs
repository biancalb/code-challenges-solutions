using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BeautifulDaysMovies
    {
        public static void CountBeautifulDays(int i, int j, int k)
        {
            int count = 0;
            var days = new List<int>();

            for (int d = i; d <= j; d++) days.Add(d);

            foreach (var num in days)
            {
                var diff = Math.Abs(num - ReverseNum(num));
                var isEvenlyDiv = diff % k == 0;
                if (isEvenlyDiv) count++;
            }

            Console.WriteLine("Beautiful days= " + count);
        }

        private static int ReverseNum(int num)
        {
            var reverse = num.ToString().Reverse().ToArray();
            return int.Parse(new string(reverse));
        }
    }
}
