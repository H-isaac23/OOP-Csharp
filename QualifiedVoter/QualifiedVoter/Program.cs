using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualifiedVoter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("You are not yet qualified to vote.");
            }
            else
            {
                Console.WriteLine("You are qualified to vote!");
            }

            Console.ReadLine();
            
        }
    }
}
