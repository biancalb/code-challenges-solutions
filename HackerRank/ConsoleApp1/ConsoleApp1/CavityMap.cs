using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CavityMap
    {
        public static void FindCavity(List<string> grid)
        {
            var newGrid = new List<string>();
            for (int c = 0; c < grid.Count; c++)
            {
                if (c > 0 && c < (grid.Count - 1))
                {
                    var currentLine = grid[c];
                    var cellLength = grid[c].Length;
                    string newCell = "";

                    for (int i = 0; i < cellLength; i++)
                    {
                        if (i > 0 && i < (cellLength - 1))
                        {
                            var right = currentLine[i + 1];
                            var left = currentLine[i - 1];
                            var top = grid[c - 1][i];
                            var bottom = grid[c + 1][i];

                            var isCavity =
                                right < currentLine[i] &&
                                left < currentLine[i] &&
                                top < currentLine[i] &&
                                bottom < currentLine[i];

                            newCell += isCavity ? "X" : currentLine[i];
                        }
                        else
                        {
                            newCell += currentLine[i];
                        }
                    }
                    newGrid.Add(newCell);
                }
                else
                {
                    newGrid.Add(grid[c]);
                }
            }
            Console.WriteLine(string.Join('\n', newGrid));
        }
    }
}
