using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCompositeRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int givenNumber;
            bool validInput = int.TryParse(Console.ReadLine(), out givenNumber);
            bool compositeExists = false; // this is just so that I can print none if there are no composite numbers below given number

            if(validInput)
            {
                Console.WriteLine("The composite numbers are: ");
                displayCompositeRecursive(givenNumber, ref compositeExists);
            } else
            {
                Console.WriteLine("You did not enter a valid input.");
            }
            

            Console.ReadLine();
        }

        static bool isPrime(int num)
        {
            if (num == 2)
            {
                return true;
            } else if (num < 2 || num % 2 == 0)
            {
                return false;
            }

            int upperLimit = (int)Math.Floor(Math.Sqrt(num));

            for(int i = 3; i <= upperLimit; i += 2)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void displayCompositeRecursive(int num, ref bool compositeExists)
        {
            if(num < 4)
            {
                if(compositeExists == false)
                {
                    Console.WriteLine("None");
                }
                return;
            }

            if (!isPrime(num))
            {
                Console.WriteLine(num);
            }

            compositeExists = true;
            displayCompositeRecursive(num - 1, ref compositeExists);
        }
    }
}
