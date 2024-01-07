using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindMedian
    {
        public static void Find(List<int> arr)
        {
            if(arr.Count % 2 != 0)
            {
                var arrOrdered = arr.OrderBy(x => x).ToList();
                var medianIndex = Math.Ceiling((decimal)arr.Count / 2);
                Console.WriteLine(arrOrdered[(int)medianIndex - 1]);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
