using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature c1 = new Creature();
            Console.WriteLine("Options:");
            Console.WriteLine("[1] Walk");
            Console.WriteLine("[2] Speak");
            Console.WriteLine("[3] Hop");
            Console.WriteLine("[4] Show Distance");
            Console.WriteLine("[5] Show number of Words Spoken");

            int choice;
            bool done = false;

            while (!done)
            {
                Console.Write("Select an action(1-5): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        c1.walk();
                        break;
                    case 2:
                        c1.speak();
                        break;
                    case 3:
                        c1.hop();
                        break;
                    case 4:
                        Console.WriteLine("Distance: " + c1.distance);
                        break;
                    case 5:
                        Console.WriteLine("Number of words spoken: " + c1.NumberOfWordsSpoken);
                        break;
                    default:
                        Console.WriteLine("Exiting program for not choosing anything from 1 to 5.");
                        done = !done;
                        break;
                }
                Console.WriteLine();
                
            }

            Console.ReadLine();

        }
    }

    class Creature
    {
        private int numberOfWalks = 0;
        private int numberofHops = 0;
        private int numberOfWordsSpoken = 0;
        private Random rand = new Random();

        private string[] texts = { "How are you", "It is a lovely day. Isn't it?", "It's a pleasure to meet you.", "Hello", "A pleasant morning to you." };
        public int distance
        {
            get
            {
                return numberOfWalks + (numberofHops*2);
            }
        }

        public int NumberOfWordsSpoken
        {
            get
            {
                return numberOfWordsSpoken;
            }
        }

        public void walk()
        {
            Console.WriteLine("walking");
            numberOfWalks += 1;
        }

        public void hop()
        {
            Console.WriteLine("hop");
            numberofHops += 1;
        }

        public void speak()
        {
            int randomIndex = rand.Next(5);

            switch (randomIndex)
            {
                case 0:
                    numberOfWordsSpoken += 3;
                    break;
                case 1:
                    numberOfWordsSpoken += 7;
                    break;
                case 2:
                    numberOfWordsSpoken += 6;
                    break;
                case 3:
                    numberOfWordsSpoken += 1;
                    break;
                case 4:
                    numberOfWordsSpoken += 5;
                    break;
                default:
                    break;
            }

            Console.WriteLine(texts[randomIndex]);
        }

    }
}
