using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UtopianTree
    {
        public static void CalculateHeight(int n)
        {
            Console.WriteLine(String.Format("{0, -10} {1, -10}", "Period", "Height"));
            int height = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i % 2 == 0) height++;
                else height *= 2;
                Console.WriteLine(String.Format("{0, -10} {1, -10}", i, height));

            }
        }
    }
}
