using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EletronicsShop
    {
        public static void GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var mostExpensive = -1;
            foreach (var keyboard in keyboards)
            {
                foreach (var drive in drives)
                {
                    var priceToPay = keyboard + drive;
                    if(priceToPay > mostExpensive && priceToPay <= b)
                    {
                        mostExpensive = priceToPay;
                    }
                }
            }
            Console.WriteLine("mostExpensive= " + mostExpensive);
        }
    }
}
