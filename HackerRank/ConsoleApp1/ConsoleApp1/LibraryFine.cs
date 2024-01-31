using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LibraryFine
    {
        public static void CalculateFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var returnedDate = new DateTime(y1, m1, d1);
            var dueDate = new DateTime(y2, m2, d2);

            Console.WriteLine("returned date= " + returnedDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("due date= " + dueDate.ToString("dd/MM/yyyy"));

            int fine;
            if (returnedDate <= dueDate)
            {
                fine = 0;
            }
            else if (returnedDate.Year == dueDate.Year)
            {
                var late = returnedDate.Subtract(dueDate);
                //Console.WriteLine("late days= " + late.Days);
            
                //var months = (late.Days / 30);
                //Console.WriteLine("late months= " + months);
            
                fine = returnedDate.Month == dueDate.Month 
                    ? late.Days * 15
                    : (returnedDate.Month - dueDate.Month) * 500;
            }
            else
            {
                fine = 10000;
            }
            Console.WriteLine("\nfine= " + fine);
        }
    }
}
