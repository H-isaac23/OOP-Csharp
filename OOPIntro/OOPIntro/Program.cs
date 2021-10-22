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
            c1.hop();
            c1.speak();
            c1.speak();
            c1.speak();
            c1.speak();
            c1.walk();
            c1.walk();
            Console.WriteLine(c1.distance);
            Console.WriteLine(c1.NumberOfWordsSpoken);
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
                return numberOfWalks + numberofHops;
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
