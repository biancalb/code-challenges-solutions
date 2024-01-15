using System;

namespace ConsoleApp1
{
    public class DayofTheProgrammer
    {
        public static void Calculate(int year)
        {
            bool isLeapYear;
            if(year > 1918) isLeapYear = DateTime.IsLeapYear(year);
            else  isLeapYear = year % 4 == 0;

            //return isLeapYear ? $"12.09.{year}" : $"13.09.{year}";            
            Console.WriteLine(year == 1918 ? $"26.09.{year}" : isLeapYear ? $"12.09.{year}" : $"13.09.{year}");
        }
    }
}
