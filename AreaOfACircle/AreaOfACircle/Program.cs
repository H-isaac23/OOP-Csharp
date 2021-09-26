using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            float pi = 3.1416f;
            float area = r * pi * pi;
            Console.WriteLine("The area of the circle with radius " + r + " is: " + area);
            Console.ReadLine();
        }
    }
}
