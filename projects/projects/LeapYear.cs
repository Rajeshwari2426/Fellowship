using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class LeapYear
    {
        public void LeapYearCheck()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine($"{year} is a Leap Year");
                    else
                        Console.WriteLine($"{year} is not a Leap Year");
                }
                else
                {
                    if (year % 4 == 0)
                        Console.WriteLine($"{year} is a Leap Year");
                    else
                        Console.WriteLine($"{year} is not a Leap Year");
                }
            }
            else
                Console.WriteLine("Enter a 4 digit number");
        }
    }
}
