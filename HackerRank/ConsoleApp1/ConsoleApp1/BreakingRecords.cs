using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BreakingRecords
    {
        public static void CountRecords(List<int> scores)
        {
            var records = new List<int>() { 0, 0 };
            var min = scores[0];
            var max = scores[0];
            
            Console.WriteLine(String.Format("{0, 10} | {1, 10} | {2, 10} | {3, 10} | {4, 10} | {5, 10} | ", "Game", "Score", "Minimum", "Maximum", "Min", "Max"));

            for (int i = 0; i < scores.Count; i++)
            {
                var score = scores[i];
                if (score > max)
                {
                    max = score;
                    records[0]++;
                }
                else if(score < min)
                {
                    min = score;
                    records[1]++;
                }
                Console.WriteLine(String.Format("{0, 10} | {1, 10} | {2, 10} | {3, 10} | {4, 10} | {5, 10} | ", i, score, min, max, records[1], records[0]));
            }

            Console.WriteLine("\nMax, Min = " + string.Join(' ', records));
        }
    }
}
