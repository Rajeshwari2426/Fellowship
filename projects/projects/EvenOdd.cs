using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class EvenOdd
    {
        public static void EvenOddCheck()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("The Number is Even");
            else
                Console.WriteLine("It is a odd number");
        }
    }
}
