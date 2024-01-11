using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacker Rank \n");
            //Console.WriteLine("Day 1");

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

            //Console.WriteLine("------------");
            //Console.WriteLine("Find Median");
            ////var arr = new List<int> { 24, 41, 21, 33, 56 };
            ////var arr = new List<int> { 12, 11, 11, 13, 11, 12, 13, 11, 12 };
            //var arr = new List<int> { 6, 5, 3, 8, 6, 3 };
            //FindMedian.Find(arr);

            //Console.WriteLine("Day 2");
            //Console.WriteLine("Lonely Integer");
            //var arr = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
            //LonelyInteger.FindElement(arr);            

            //Console.WriteLine("Diagonal Difference");

            ////var arr = new List<List<int>>() {
            ////    new List<int>() { 1, 2, 3 },
            ////    new List<int>() { 4, 5, 6 },
            ////    new List<int>() { 9, 8, 9 },
            ////};                       
            //var arr = new List<List<int>>() {
            //    new List<int>() { 11, 2, 4 },
            //    new List<int>() { 4, 5, 6 },
            //    new List<int>() { 10, 8, -12 },
            //};
            //DiagonalDifference.Calculate(arr);

            //Console.WriteLine("Counting Sort");
            ////var arr = new List<int> { 1, 1, 3, 2, 1 };
            ////var arr = new List<int> { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 };
            //var arr = new List<int> { 63, 54, 17, 78, 43, 70, 32, 97, 16, 94, 74, 18, 60, 61, 35, 83, 13, 56, 75, 52, 70, 12, 24, 37, 17, 0, 16, 64, 34, 81, 82, 24, 69, 2, 30, 61, 83, 37, 97, 16, 70, 53, 0, 61, 12, 17, 97, 67, 33, 30, 49, 70, 11, 40, 67, 94, 84, 60, 35, 58, 19, 81, 16, 14, 68, 46, 42, 81, 75, 87, 13, 84, 33, 34, 14, 96, 7, 59, 17, 98, 79, 47, 71, 75, 8, 27, 73, 66, 64, 12, 29, 35, 80, 78, 80, 6, 5, 24, 49, 82, };
            //CountingSort1.Sort(arr);

            //Console.WriteLine("Day 3");
            //Console.WriteLine("CaeserCipher");
            ////var str = "middle-Outz";
            ////var str = "abcdefghijklmnopqrstuvwxyz";           //2
            ////var str = "1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M"; //27
            //var str = "Hello_World!"; //4
            //CaeserCipher.Encrypt(str, 4);

            Console.WriteLine("PalindromeIndex \n");
            string str = "abac";
            str = "bcbc";
            str = "baa";
            str = "aaab";
            str = "abcd eed mcba";
            str = "hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh";
            str = "quyjjdcgsvvsgcdjjyq";
            PalindromeIndex.Find(str);
            Console.WriteLine(str.Length);

        }
    }
}
