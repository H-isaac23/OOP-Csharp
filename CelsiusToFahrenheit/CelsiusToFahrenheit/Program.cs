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
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            double celsius = (5 / 9.0) * (temp - 32);
            Console.WriteLine("\n" + temp + " fahrenheit in celsius is: " + celsius);
            Console.ReadLine();
        }
    }
}
