using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 9, 4, 3, 5, 1, 7 };

            Console.WriteLine("Array Operations");
            
            Console.WriteLine("\nAscending");
            ArrayOperations.SortAsc(arr);            
            
            Console.WriteLine("\nDescending");
            ArrayOperations.SortDesc(arr);

            Console.WriteLine("\nMininum value");
            ArrayOperations.FindMin(arr);

            Console.WriteLine("\nMaximum value");
            ArrayOperations.FindMax(arr);
        }
    }
}
