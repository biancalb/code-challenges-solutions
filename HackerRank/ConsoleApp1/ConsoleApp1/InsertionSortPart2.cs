using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class InsertionSortPart2
    {
        public static void Sort(int n, List<int> arr)
        {
            for (int i = 1; i < n; i++)
            {
                var current = arr[i];
                var auxIndex = i;
                for (int j = i - 1; j >= 0 ; j--)
                {
                    var previous = arr[j];

                    if (current < previous)
                    {
                        arr[j] = current;
                        arr[auxIndex] = previous;
                        current = arr[j];
                        auxIndex--;
                    }
                }
                Console.WriteLine(string.Join(' ', arr));
            }
        }
    }
}
