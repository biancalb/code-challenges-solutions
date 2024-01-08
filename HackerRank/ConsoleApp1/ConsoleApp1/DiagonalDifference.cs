using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class DiagonalDifference
    {
        public static void Calculate(List<List<int>> arr)
        {
            var mainDiagonalIndex = 0;
            var secondaryDiagonalIndex = arr[0].Count - 1;

            var mainDiagonal = new List<int>();
            var secondaryDiagonal = new List<int>();

            foreach (var line in arr)
            {
                mainDiagonal.Add(line[mainDiagonalIndex]);
                secondaryDiagonal.Add(line[secondaryDiagonalIndex]);

                mainDiagonalIndex++;
                secondaryDiagonalIndex--;
            }

            //Console.WriteLine(string.Join(',', mainDiagonal));
            //Console.WriteLine(string.Join(',', secondaryDiagonal));
            
            Console.WriteLine(Math.Abs(mainDiagonal.Sum() - secondaryDiagonal.Sum()));
        }
    }
}
