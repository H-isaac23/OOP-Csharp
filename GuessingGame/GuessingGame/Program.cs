using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int secret_number = number.Next(1, 10);
            int guessLeft = 3;
            int guess;


            while(guessLeft > 0)
            {
                Console.WriteLine("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if(guess == secret_number)
                {
                    Console.WriteLine("Congratulations! You picked the right number!");
                    break;
                }

                guessLeft--;

                if (guess < secret_number)
                {
                    Console.Write(String.Format("Nice try... But {0} is not the number that I am thinking of. Try Higher! [{1} ", guess, guessLeft));
                    if(guessLeft != 1)
                    {
                        Console.WriteLine("Attempts Left]");
                    }
                    else
                    {
                        Console.WriteLine("Attempt Left]");
                    }
                    
                }
                else if (guess > secret_number)
                {
                    Console.Write(String.Format("Sorry... But {0} is not the number that I am thinking of. Try Lower! [{1} ", guess, guessLeft));
                    if (guessLeft != 1)
                    {
                        Console.WriteLine("Attempts Left]");
                    }
                    else
                    {
                        Console.WriteLine("Attempt Left]");
                    }

                }
                Console.WriteLine();
                
            }

            if(guessLeft == 0)
            {
                Console.WriteLine("Game Over!");
            }

            Console.ReadLine();
        }
    }
}
