using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberLineJumps
    {
        public static void IsPossible(int x1, int v1, int x2, int v2)
        {
            bool isPossible;

            if(x1 == x2)
            {
                isPossible = true;
            }
            else
            {
                var checkPosition = !((x2 > x1) && (v2 > v1));

                var isvalid = (v2 - v1) != 0 ? (x2 - x1) % (v2 - v1) == 0 : false;

                isPossible = checkPosition && isvalid;
            }
            Console.WriteLine( isPossible ? "YES" : "NO");
        }
    }
}
