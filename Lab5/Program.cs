using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of side for a pair of dice.");
            int Sides = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Roll the dice.");

            // method for rolling the dice
            randomNumber(Sides);
        }


        public static void randomNumber(int Sides)
        {

            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {

                int randomNumber = random.Next(0, Sides);
                Console.WriteLine(randomNumber);

            }
        }
    }
}
