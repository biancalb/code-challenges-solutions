using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EqualizeTheArray
    {
        public static void Calculate(List<int> arr)
        {
            var arrGrouped = arr.GroupBy(a => a);

            var maxOcurr = arrGrouped.Select(c => c.Count()).Max();

            Console.WriteLine(arr.Count - maxOcurr);
        }
    }
}
