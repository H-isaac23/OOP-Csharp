using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1s0s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string length: ");
            int stringLength;
            bool validInput = int.TryParse(Console.ReadLine(), out stringLength);

            if (validInput)
            {
                Console.WriteLine("All possible combinations are: ");
                generate("", "0", 1, stringLength);
                generate("", "1", 1, stringLength);
            } else
            {
                Console.WriteLine("You did not enter a valid input.");
            }

            Console.ReadLine();
        }

        static void generate(string currentString, string toAdd, int currentLength, int finalLength)
        {
            string newString = currentString + toAdd;

            if(currentLength == finalLength)
            {
                Console.WriteLine(newString);
                return;
            }
            generate(newString, "0", currentLength + 1, finalLength);
            generate(newString, "1", currentLength + 1, finalLength);
        }
    }
}
