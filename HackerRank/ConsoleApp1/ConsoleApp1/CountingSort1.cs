using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountingSort1
    {
        public static void Sort(List<int> arr)
        {
            var frequencyArray = Enumerable.Repeat(0, 100).ToList();
            foreach(var number in arr)
            {
                frequencyArray[number] += 1;
            }

            var sortedArray = new List<int>();

            for(int index = 0; index < frequencyArray.Count; index++)
            {
                for(int numberOfOccurrences = 0; numberOfOccurrences < frequencyArray[index]; numberOfOccurrences++)
                {
                    sortedArray.Add(index);
                }             
            }

            Console.WriteLine("Frequency array = " + string.Join(' ', frequencyArray) + '\n');
            Console.WriteLine("Sorted array = " + string.Join(' ', sortedArray));
        }
    }
}
