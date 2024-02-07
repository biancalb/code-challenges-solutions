using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LisasWorkbook
    {
        public static void CountSpecialProblems(int n, int k, List<int> arr)
        {
            var specialProblem = 0;
            var totalPages = 0;
            for (int chapter = 1; chapter <= n; chapter++)
            {
                Console.WriteLine("chapter= " + chapter);
                var problemsPerChapter = arr[chapter - 1];

                var pages = Math.Ceiling((decimal)problemsPerChapter / k);

                var lastProblemInPage = 0;
                var problemsPerPage = new List <Tuple<int, int>>();

                for (int p = 1; p <= pages; p++)
                {
                    Console.WriteLine("page= " + p);
                    totalPages++;

                    lastProblemInPage += lastProblemInPage + k > problemsPerChapter
                        ? problemsPerChapter % k
                        : k;
                    
                    problemsPerPage.Add(new Tuple<int, int> (totalPages, lastProblemInPage));

                    if (problemsPerPage.Count == 1)
                    {
                        var problemListInPage = Enumerable.Range(1, lastProblemInPage);
                        Console.WriteLine("problemListInPage= " + string.Join(' ', problemListInPage));
                        if (problemListInPage.Contains(totalPages)) specialProblem++;
                    }
                    else
                    {
                        var start = problemsPerPage[(p - 1) - 1].Item2 + 1;
                        var count = Math.Abs(start - lastProblemInPage) + 1;
                        var problemListInPage = Enumerable.Range(start, count);
                        Console.WriteLine("problemListInPage= " + string.Join(' ', problemListInPage));
                        if (problemListInPage.Contains(totalPages)) specialProblem++;

                    }

                    Console.WriteLine("specialProblem= " + specialProblem + "\n");
                }
                Console.WriteLine("----------------\n");
            }

            Console.WriteLine("total special problem = " + specialProblem);
        }
    }
}
