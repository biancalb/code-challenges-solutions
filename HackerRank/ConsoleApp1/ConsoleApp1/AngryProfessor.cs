using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class AngryProfessor
    {
        public static void IsClassCancelled(int k, List<int> a)
        {
            var studentsOnTime = a.Count(a => a <= 0);
            Console.WriteLine("studentsOnTime= " + studentsOnTime);
            var isClassCancelled = studentsOnTime >= k ? "NO" : "YES";
            Console.WriteLine(isClassCancelled);
        }
    }
}
