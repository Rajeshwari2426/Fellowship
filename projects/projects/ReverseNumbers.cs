using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    class ReverseNumbers
    {
        public static void FindReverseNumber()
        {
            Console.WriteLine("Please enter number to be reversed");
            int number=Convert.ToInt32(Console.ReadLine());
            int remainder, reverse = 0;
            while(number > 0)
            {
                remainder=number% 10;
                reverse=(reverse*10)+remainder;
                number=number/10;
            }
            Console.WriteLine("after reverse number:" + reverse);
        }

    }
}
