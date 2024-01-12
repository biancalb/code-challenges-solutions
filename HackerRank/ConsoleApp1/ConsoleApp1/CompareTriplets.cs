using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CompareTriplets
    {
        public static void ComputePoints(List<int> a, List<int> b)
        {
            var totalPoints = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i]) continue;

                if (a[i] > b[i])
                {
                    totalPoints[0]++;
                }
                else if (a[i] < b[i])
                {
                    totalPoints[1]++;
                }
            }
            Console.WriteLine(string.Join(' ', totalPoints));
        }
    }
}
