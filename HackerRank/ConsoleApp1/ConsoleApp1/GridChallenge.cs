using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GridChallenge
    {
         public static void Rearrange(List<string> grid)
         {
            var orderedGrid = new List<string>(grid.Count);
            foreach (var row in grid)
            {
                orderedGrid.Add(string.Concat(row.OrderBy(c => c)));
            }

            var checkColumnOrder = new List<bool>(grid.Count);

            for (int column = 0; column < orderedGrid[0].Length; column++)
            {
                string col = string.Empty;

                for (int row = 0; row < grid.Count; row++)
                {
                    col += orderedGrid[row][column];
                }
                //Console.WriteLine(col);
                var check = string.Equals(col, string.Concat(col.OrderBy(c => c)));
                checkColumnOrder.Add(check);
                //Console.WriteLine('\n');
            }

            Console.WriteLine(checkColumnOrder.All(x => x) ? "YES" : "NO");

            //foreach (var validation in checkColumnOrder)
            //{
            //    Console.WriteLine(validation.ToString());
            //}
        }
    }
}
