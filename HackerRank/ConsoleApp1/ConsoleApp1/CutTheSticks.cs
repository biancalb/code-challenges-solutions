using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CutTheSticks
    {
        public static void Cut(List<int> arr)
        {
            var sticks = new List<int>();
            while(arr.Count > 0)
            {
                var shortest = arr.Min();
                Console.WriteLine("shortest= " + shortest);
                
                arr = arr.Select(s => s - shortest).ToList();
                Console.WriteLine("arr= " + string.Join(' ', arr));

                //var longest = arr.Max();
                //Console.WriteLine("longest= " + longest);

                //var countRemoved = arr.RemoveAll(s => s == longest);
                sticks.Add(arr.Count);
                arr = arr.Where(s => s != 0).ToList();
                Console.WriteLine("arr= " + string.Join(' ', arr));
                Console.WriteLine("\n");
            }
            Console.WriteLine("sticks= " + string.Join(' ', sticks));
        }
    }
}
