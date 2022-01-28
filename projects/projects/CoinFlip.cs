using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class CoinFlip
    {
        public void FlipCoin()
        {
            string result = "";
            int headCount = 0;
            int tailCount = 0;

            Console.WriteLine("Enter how many times you want to flip the coin : ");
            double trials = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = 1; i <= trials; i++)
            {
                double randomNum = random.NextDouble();

                if (randomNum < 0.5)
                {
                    result = "Tails";
                    tailCount += 1;
                }
                else
                {
                    result = "Heads";
                    headCount += 1;
                }
                Console.WriteLine(result);
            }
            double headsPercentage = (headCount / trials) * 100;
            double tailsPercentage = (tailCount / trials) * 100;
            Console.WriteLine($"Heads Percentage: {headsPercentage} \nTails Percentage: {tailsPercentage}");
        }
    }
}

