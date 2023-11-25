using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstFactorial
    {
        public static int Calculate(int num)
        {
            int fac = 1;

            while(num > 1)
            {
                fac *= num;
                num--;
            }
            Console.WriteLine(fac);
            return num;
        }
    }
}
