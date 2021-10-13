using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSumRecursive
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give a number: ");
            int givenNumber;
            bool validInput = int.TryParse(Console.ReadLine(), out givenNumber);
            int sum = 0;

            if (validInput)
            {
                recursivePrimeSum(givenNumber, ref sum);
                Console.WriteLine($"The sum of all prime numbers from {givenNumber} to 1 is: {sum}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid input.");
            }
            

            Console.ReadLine();
        }

        static bool isPrime(int num)
        {
            if(num == 2)
            {
                return true;
            } else if ( num <= 1 || num % 2 == 0)
            {
                return false;
            }

            int upperLimit = (int)Math.Floor(Math.Sqrt(num));
            for(int i = 3; i <= upperLimit; i += 2)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void recursivePrimeSum(int currentNumber, ref int sum)
        {
            if(currentNumber < 2)
            {
                return;
            }

            if (isPrime(currentNumber))
            {
                sum += currentNumber;
            }

            recursivePrimeSum(currentNumber - 1, ref sum);
        }
    }
}
