using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class DesignerPDFViewer
    {
        public static void CalculateArea(List<int> h, string word)
        {
            var alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToList();
            const int letterWide = 1;
            int tallest = 0;
            int area = 0;

            foreach (var c in word)
            {
                var alphabetIndex = alphabet.IndexOf(c);
                var height = h[alphabetIndex];

                if (height > tallest) tallest = height;
            }
            Console.WriteLine("tallest= " + tallest);

            area = tallest * letterWide * word.Length;

            Console.WriteLine("area= " + area);

        }
    }
}
