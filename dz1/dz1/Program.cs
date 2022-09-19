using System;
using System.Globalization;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.WriteLine("Уравнение y = 4*(x-3)^6 -7*(x-3)^3 +2");
            double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
            Console.WriteLine($"y={y}");
        }
    }
}
