using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class LargestNumber
    {
        public void GetLargest()
        {
            Console.Write("Input the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write($"{num1} is the greatest among three. ");
                }
                else
                {
                    Console.Write($"{num3} is the greatest among three.");
                }
            }
            else if (num2 > num3)
                Console.Write($"{num2} is the greatest among three");
            else
                Console.Write($"{num3} is the greatest among three.");
        }

    }
}
