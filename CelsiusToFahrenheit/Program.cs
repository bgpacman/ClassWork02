using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            // T(°F) = T(°C) × 1.8 + 32
            var f = (c * 1.8) + 32;

            Console.WriteLine(Math.Round(f, 2));
        }
    }
}
