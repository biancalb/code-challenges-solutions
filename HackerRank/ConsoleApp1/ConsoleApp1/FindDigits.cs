using System;

namespace ConsoleApp1
{
    public class FindDigits
    {
        public static void CountDivisors(int n)
        {
            int count = 0;
            foreach (var strN in n.ToString())
            {
                var divisor = int.Parse(strN.ToString());
                if (divisor != 0  && n % divisor == 0) count++;
            }
            Console.WriteLine("count divisor= " + count);
        }
    }
}
