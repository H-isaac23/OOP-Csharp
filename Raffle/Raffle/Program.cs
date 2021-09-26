using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] defaultNames = { "Hoshimachi", "Minato", "Nakiri", "Oozora", "Ninomae", "Shirogane", "Uruha", "Usada", "Houshou", "Shiranui",
                                      "Momosuzu", "Shishiro", "Omaru", "Mano", "Yukihana", "Tsukumo", "Ceres", "Nanashi", "Ouro", "Hakos"}; // japanese names po XD
            String[] currentNames = defaultNames;
            String[] nameCache;
            String drawnName;
            Random random = new Random();
            int action;
            int arrLength = currentNames.Length;

            do
            {
                Console.WriteLine("[1] Draw");
                Console.WriteLine("[2] Reset");
                Console.WriteLine("[3] Exit");
                Console.Write("Enter your action: ");
                action = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (action == 1)
                {

                    // shuffle the array
                    currentNames = currentNames.OrderBy(_ => random.Next()).ToArray();
                    // Console.WriteLine(String.Format("currentNames[0] - {0}", currentNames[0])); 
                    // ^^^ commented proof for shuffled array

                    // draws randomly from the array
                    int drawIndex = random.Next(0, arrLength);
                    drawnName = currentNames[drawIndex];

                    // display name of winner
                    Console.WriteLine(String.Format("Congratulations to {0}. You are the winner!", drawnName));
                    Console.WriteLine();

                    // remove the drawn name from the array
                    // assigns the currentNames array to an empty array of length arrlength - 1

                    arrLength--;
                    nameCache = currentNames;
                    currentNames = new String[arrLength];
                    int i = 0, currentNameIndex = 0;
                    
                    // assigns every name except the winners
                    while(i < arrLength)
                    {
                        if(!nameCache[currentNameIndex].Equals(drawnName))
                        {
                            currentNames[i] = nameCache[currentNameIndex];
                            i++;
                        }
                        currentNameIndex++;
                    }


                }
                else if (action == 2)
                {
                    // resets the array to the default names
                    currentNames = defaultNames;
                }
                else if (action == 3)
                {
                    Console.WriteLine("Thanks for playing!");
                }
            } while (action != 3);

            Console.ReadLine();
        }
    }
}
