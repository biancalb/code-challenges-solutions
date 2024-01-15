using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MigratoryBirds
    {
        //find the minimum most seen
        public static void Calculate(List<int> arr)
        {
            var arrGrouped = arr.GroupBy(b => b);
            var maxOcurr = arrGrouped.Select(c => c.Count()).Max();
            Console.WriteLine("maxOccur= " + maxOcurr);

            var minValue = arrGrouped.Where(c => c.Count() == maxOcurr).Select(c => c.Key).Min();
            Console.WriteLine("minValue in maxOccur= " + minValue);
        }
    }
}
