using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FindIntersection
    {
        public static void Find(string[] str)
        {
            Console.WriteLine(FindIntersec(str));
        }

        public static string FindIntersec(string[] str)
        {
            int[] one = str[0].Split(",").Select(n => int.Parse(n)).ToArray();
            int[] two = str[1].Split(",").Select(n => int.Parse(n)).ToArray();

            List<int> intersec = new();
            foreach(int n in one)
            {
                if (two.Contains(n)) intersec.Add(n);
            }

            return intersec.Count == 0 ? "false" : String.Join(',', intersec.OrderBy(n => n));

        }
    }
}
