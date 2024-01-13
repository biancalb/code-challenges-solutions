using System;

namespace ConsoleApp1
{
    public class StairCase
    {
        //string to the left String.Format("{0,–10}", text)
        //string to the right String.Format("{0,10}", text)
        public static void Generate(int n)
        {
            string str;
            for (int i = 0; i < n; i++)
            {
                str = string.Empty;
                for (int y = 0; y < i + 1; y++)  str += "#";
                if (str.Length < n) str = str.PadLeft(n, ' ');
                Console.WriteLine(str);
                //Console.WriteLine(String.Format("{0, 10}", str += "#"));
            }
        }
    }
}
