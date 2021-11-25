using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] x = new Shape[1];
            x[0] = new Shape();

        }
    }

    class Shape
    {
        public Shape(){
            name = "Hi";
        }

        public String name
        {
            get; set;
        }
        public void draw()
        {
            Console.WriteLine("Hi");
        }
    }

    class Triangle : Shape {
        public new void draw()
        {
            Console.WriteLine("Hello");
        }
    }

}
