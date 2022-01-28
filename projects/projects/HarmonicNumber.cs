using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class HarmonicNumber
    {
        public static void GetHarmonic()
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            for (double i = 1; i <= n; i++)
            {
                Console.WriteLine($"1/{i}");
                result += 1 / i;
            }
            Console.WriteLine("nth Harmonic is : " +result);
        }
    }
}
