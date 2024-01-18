using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountingValleys
    {
        public enum Track
        {
            Valley,
            Mountain,
            SeaLevel
        }

        public static void Count(int steps, string path)
        {
            int valley = 0;
            int amountSteps = 0;

            var t = Track.SeaLevel;
            //foreach (var step in path)
            //{
            //    Console.WriteLine("step= " + step);

            //    amountSteps += step == 'U' ? 1 : -1;
            //    Console.WriteLine("amountSteps= " + amountSteps);

            //    if (amountSteps == 0) valley += 1;
            //    Console.WriteLine("valley= " + valley + "\n");
            //}            

            foreach (var step in path)
            {
                Console.WriteLine("step= " + step);
                
                amountSteps += step == 'U' ? 1 : -1;
                Console.WriteLine("amountSteps= " + amountSteps);

                if (t == Track.Valley && amountSteps == 0) valley += 1;
                Console.WriteLine("valley= " + valley + "\n");

                t = amountSteps > 0 ? Track.Mountain : amountSteps < 0 ? Track.Valley : Track.SeaLevel;
            }



            Console.WriteLine("valleys= " + valley);
        }
    }
}
