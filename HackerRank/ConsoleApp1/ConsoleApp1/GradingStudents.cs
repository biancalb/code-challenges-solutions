using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GradingStudents
    {
        public static void Avaliate(List<int> grades)
        {
            Console.WriteLine(string.Join(' ', grades));
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38) continue;
                int resto = grades[i];
                int multiple = grades[i];

                while (resto != 0)
                {
                    resto = multiple % 5;
                    if (resto != 0) multiple++;
                }

                if (multiple - grades[i] < 3) grades[i] = multiple;
            } 
            Console.WriteLine(string.Join(' ', grades));
        }
    }
}
