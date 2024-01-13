using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubarrayDivision
    {
        public static void Calculate(List<int> s, int d, int m)
        {
            if (s.Count < m) Console.WriteLine("The array length must be bigger than m");
            var count = 0;

            for (int i = 0; i < s.Count; i++)
            {
                if (s.Count - i <= m -1) continue;

                Console.WriteLine("i= " + i);
                Console.WriteLine("s[i]= " + s[i]);
                Console.WriteLine('\n');
                var sum = 0;
                for (int conseqSquares = i; conseqSquares < i + m; conseqSquares++)
                {

                    Console.WriteLine("Find Conseq");
                    Console.WriteLine("sum= " + sum);
                    Console.WriteLine("conseq[i]= " + conseqSquares);
                    sum += s[conseqSquares];
                    Console.WriteLine("----");
                }
                Console.WriteLine("sum= " + sum);
                Console.WriteLine('\n');
                if (sum == d) count++;
            }
            Console.WriteLine("count= " + count);
        }
    }
}
