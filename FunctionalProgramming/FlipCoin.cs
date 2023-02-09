using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class FlipCoin
    {
        public void Percentage()
        {
            Console.WriteLine("\nNo of times you want to Toss the Coin: ");
            int toss = Convert.ToInt32(Console.ReadLine());
            int headCount = 0, tailCount = 0;
            Random random = new Random();
            for (int i = 0; i < toss; i++)
            {
                double randomFlip = random.NextDouble();
                if (randomFlip < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Heads= {0} times", headCount);
            Console.WriteLine("Tails= {0} times", tailCount);
            double headPercentage = (headCount * 100) / toss;
            double tailPercentage = (tailCount * 100) / toss;
            Console.WriteLine("Head Percentage = {0}% \nTail Percentage = {1}%", headPercentage, tailPercentage);
        }
    }
}
