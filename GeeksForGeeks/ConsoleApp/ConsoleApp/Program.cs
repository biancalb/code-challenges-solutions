using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Number Occurring Odd Number of Times");
            //var arr = new int[] { 1, 2, 3, 2, 3, 1, 3};
            var arr = new int[] { 5, 7, 2, 7, 5, 2, 5 };
            OddNumberofTimes.FindNumber(arr);
        }
    }
}
