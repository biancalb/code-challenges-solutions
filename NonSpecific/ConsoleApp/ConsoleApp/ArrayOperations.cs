using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ArrayOperations
    {
        public static void SortAsc(int[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = i+1; y < arr.Length; y++)
                {
                    if(arr[i] > arr[y])
                    {
                        var temp = arr[i];
                        arr[i] = arr[y];
                        arr[y] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', arr));
        }

        public static void SortDesc(int[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
            for (int i = 0; i < arr.Length; i++)
            {
                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (arr[i] < arr[y])
                    {
                        var temp = arr[i];
                        arr[i] = arr[y];
                        arr[y] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', arr));
        }

        public static void FindMin(int[] arr)
        {
            int min = arr[0];
            foreach (var num in arr.Skip(1))
            {
                if (num < min) min = num;
            }
            Console.WriteLine("Min= " + min);
        }        
        public static void FindMax(int[] arr)
        {
            int max = arr[0];
            foreach (var num in arr.Skip(1))
            {
                if (num > max) max = num;
            }
            Console.WriteLine("Max= " + max);
        }
    }
}
