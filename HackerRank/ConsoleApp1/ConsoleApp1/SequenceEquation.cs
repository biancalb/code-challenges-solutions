using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SequenceEquation
    {
        public static void PermutationEquation(List<int> p)
        {
            int n = p.Max();

            var yValues = new List<int>();

            for (int x = 1; x <= n; x++)
            {
                yValues.Add(CalculateY(p, x));
            }
            Console.WriteLine(string.Join('\n', yValues));
        }

        private static int CalculateY(List<int> p, int index)
        {
            for (int loop = 0; loop < 2; loop++)
            {
                index = p.IndexOf(index) + 1;
            }

            return index;
        }
    }
}
