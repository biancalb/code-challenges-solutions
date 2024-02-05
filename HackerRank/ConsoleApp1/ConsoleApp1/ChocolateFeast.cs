using System;

namespace ConsoleApp1
{
    public class ChocolateFeast
    {
        public static void Calculate(int n, int c, int m)
        {
            var countCanBuy = n / c;
            var freeChocolate = CountFreeChoc(countCanBuy, m);

            var total = countCanBuy + freeChocolate;
            Console.WriteLine("total= " + total);
        }

        private static int CountFreeChoc(int coutCanBuy, int m)
        {
            var choc = 0;
            var currentAmount = coutCanBuy;

            while (currentAmount >= m)
            {
                var wrapperToChoc = currentAmount / m;
                choc += wrapperToChoc;

                currentAmount = wrapperToChoc + (currentAmount % m);
            }

            return choc;
        }
    }
}
