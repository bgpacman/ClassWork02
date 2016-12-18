using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double faren = (celsius * 9) / 5 + 32;

            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
        }
    }
}
