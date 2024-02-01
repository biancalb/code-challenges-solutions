using System;
using System.Linq;

namespace ConsoleApp1
{
    public class RepeatedString
    {
        public static void CountRepeatedA(string s, long n)
        {
            var originalStrACount = s.Count(c => c == 'a');
            var p = n / s.Length;
            var rest = n - (p * s.Length);

            var leftS = s.Take((int)rest).Count(c => c == 'a');

            var totalACount = (originalStrACount * p) + leftS;
            Console.WriteLine("count= " + totalACount);
        }
    }
}
