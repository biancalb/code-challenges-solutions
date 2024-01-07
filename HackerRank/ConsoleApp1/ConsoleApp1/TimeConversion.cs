using System;
using System.Globalization;

namespace ConsoleApp1
{
    public class TimeConversion
    {
        public static void Convert(string s)
        {
            // 07:05:45PM to 19:05:45

            Console.WriteLine(
                DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture)
                .ToString("HH:mm:ss")
            );
        }
    }
}
