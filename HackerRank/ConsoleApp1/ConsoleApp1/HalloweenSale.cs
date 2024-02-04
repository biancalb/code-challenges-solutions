using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class HalloweenSale
    {
        public static void HowManyGames(int p, int d, int m, int s)
        {
            var countCanBuy = 0;

            if (p < s)
            {
                var prices = new List<int>();
                var valueToPay= 0;

                for (int cost = p; cost > m; cost -= d)
                {
                    prices.Add(cost);
                }

                Console.WriteLine("prices= " + string.Join(' ', prices));

                foreach (var price in prices)
                {
                    if (valueToPay + price <= s)
                    {
                        countCanBuy++;
                        valueToPay += price;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("valueToPay= " + valueToPay);
                Console.WriteLine("countCanBuy= " + countCanBuy);
                
                if (countCanBuy == prices.Count)
                {
                    while (valueToPay + m <= s)
                    {
                        countCanBuy++;
                        valueToPay += m;
                        Console.WriteLine("\n");
                        Console.WriteLine("valueToPay= " + valueToPay);
                        Console.WriteLine("countCanBuy= " + countCanBuy);
                    }
                }
            }
            Console.WriteLine("can buy= " + countCanBuy);
        }
    }
}
