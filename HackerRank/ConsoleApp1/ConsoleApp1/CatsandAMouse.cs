using System;

namespace ConsoleApp1
{
    public class CatsAndAMouse
    {
        public static void Main(int x, int y, int z)
        {
            var mouseA = Math.Abs(z - x);
            var mouseB = Math.Abs(z - y);

            string resp = "";

            if (mouseA < mouseB) resp = "Cat A";
            else if (mouseB < mouseA) resp = "Cat B";
            else if (mouseB == mouseA) resp = "Mouse C";

            Console.WriteLine("resp= " + resp);
        }
    }
}
