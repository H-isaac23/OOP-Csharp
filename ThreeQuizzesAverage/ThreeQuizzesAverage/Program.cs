using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeQuizzesAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three quizzes: ");
            int q1 = Convert.ToInt32(Console.ReadLine());
            int q2 = Convert.ToInt32(Console.ReadLine());
            int q3 = Convert.ToInt32(Console.ReadLine());
            float ave = (q1 + q2 + q3) / 3.0f;
            Console.WriteLine("Your average for the three quizzes is: " + ave);
            Console.ReadLine();
        }
    }
}
