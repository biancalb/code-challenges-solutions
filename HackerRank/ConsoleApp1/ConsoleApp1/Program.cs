using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacker Rank");
            Console.WriteLine("Day 1");

            //Console.WriteLine("Plus Minus");
            //var arr = new List<int> { -4, 3, -9, 0, 4, 1 };
            //PlusMinus.Calculate(arr);

            //Console.WriteLine("------------");
            //Console.WriteLine("Min Max Sum");
            ////var arr = new List<int> { 1, 3, 5, 7, 9 };
            //var arr = new List<int> { 1, 2, 3, 4, 5 };
            //MinMaxSum.Calculate(arr);

            //Console.WriteLine("------------");
            //Console.WriteLine("Time Conversion");
            //var time = "07:05:45PM";
            //TimeConversion.Convert(time);            
            
            Console.WriteLine("------------");
            Console.WriteLine("Find Median");
            var arr = new List<int> {  24, 41, 21, 33, 56 };
            FindMedian.Find(arr);

        }
    }
}
