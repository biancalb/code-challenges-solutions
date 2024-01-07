using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinMaxSum
    {
        public static void Calculate(List<int> arr)
        {
            var arrOrdererd = arr.OrderBy(x => x);
            var min = arrOrdererd.Take(4).Sum(x => (long)x);
            var max = arrOrdererd.Skip(1).Sum(x => (long)x);

            Console.WriteLine($"{min} {max}");
        }
    }
}
