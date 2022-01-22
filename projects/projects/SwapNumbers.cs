using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
     class SwapNumbers
    {
        public static void SwappingNumbers()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("Please enter  first number");
            firstNum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            secondNum=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before exchanging values:{0},{1}",firstNum,secondNum);
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("after swapping numbers:{0},{1}", firstNum, secondNum);
        }

    }
}
