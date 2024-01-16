using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BillDivision
    {
        public static void CheckBill(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            var costPerPerson = bill.Sum() / 2;

            Console.WriteLine(costPerPerson == b ? "Bon Appetit" : b - costPerPerson);
        }
    }
}
