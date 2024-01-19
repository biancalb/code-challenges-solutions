using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TheHurdleRace
    {
        public static void CountPotions(int k, List<int> height)
        {
            var maxHeight = height.Max();
            var potions = k < maxHeight ? maxHeight - k : 0;
            Console.WriteLine("potions= " + potions);
        }
    }
}
