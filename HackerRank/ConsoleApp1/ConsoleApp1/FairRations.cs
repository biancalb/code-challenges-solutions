using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FairRations
    {
        public static void Main(List<int> B)
        {
            var distributedBreads = 0;
            
            for (int currentIndex = 0; currentIndex < B.Count; currentIndex++)
            {
                if (B[currentIndex] % 2 != 0)
                {
                    B[currentIndex]++;
                    int nextIndex = currentIndex == B.Count - 1 ? 0 : currentIndex + 1;
                    B[nextIndex]++;
                    distributedBreads+=2;
                }
            }
            Console.WriteLine("B= " + string.Join(' ', B));
            string res = B.Any(item => item % 2 != 0) ? "NO" : distributedBreads.ToString();
            Console.WriteLine(res);
        }
    }
}
