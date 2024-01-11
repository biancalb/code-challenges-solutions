using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    public class RecursiveSum
    {
        public static void Calculte(string n, int k)
        {
            if(n.Length == 1)
            {
                //return n;
                Console.WriteLine(n);
            }
            else
            {
#warning Optimize execution time limit
                var superDigit = BigInteger.Parse(n);

                superDigit = CalculateSuperDigit(superDigit);

                if(k % 10 != 0) superDigit = CalculateSuperDigit(superDigit *= k);

                Console.WriteLine("superDigit= " + superDigit);
            }
        }

        private static BigInteger CalculateSuperDigit(BigInteger superDigit)
        {
            while (superDigit / 10 > 0)
            {
                superDigit = SumDigits(superDigit);
                Console.WriteLine("superDigit=" + superDigit);
            }
            return superDigit;
        }

        static BigInteger SumDigits(BigInteger num) 
        {
            BigInteger sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("sum=" + sum);
            return sum;
        }
    }
}