using System;

namespace ConsoleApp1
{
    public class JumpingOnTheCloud
    {
        public static void CalculateEnergyLevel(int[] c, int k)
        {
            int energyLevel = 100;
            for (int i = 0; i < c.Length; i+=k)
            {
                if (energyLevel < 100 && i == 0) break;

                var nextIndex = i + k >= c.Length 
                    ? Math.Abs(c.Length - (i + k)) 
                    : i + k;

                energyLevel -= 1 + (c[nextIndex] == 1 ? 2 : 0);

                Console.WriteLine($"indexes= {i} -> {nextIndex}");
                Console.WriteLine($"clouds= {c[i]} -> {c[nextIndex]}");
                Console.WriteLine("energyLevel= " + energyLevel);
                Console.WriteLine("\n");
                
                if (i + k >= c.Length) i = Math.Abs(c.Length - (i + k)) - k;
            }
        }
    }
}
