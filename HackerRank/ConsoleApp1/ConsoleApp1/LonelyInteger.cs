using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class LonelyInteger
    {
        //find the unique element
        public static void FindElement(List<int> a)
        {
            var unique = a.GroupBy(x => x).Where(g => g.Count() == 1).Select(c => c.Key).ToList();
            Console.WriteLine(unique[0]);
        }
    }
}
