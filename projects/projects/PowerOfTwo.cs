using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class PowerOfTwo
    {
        public static void PrintTable()
        { 
            Console.WriteLine("enter number to print  powers of 2: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result=1;
            for (int i = 1; i <= n; i++)
            {
                
                
                result=result*2;
                Console.WriteLine($"{2} ^ {i} = {result}" );
            }
        }
       /* for ((i=0;i<=n;i++))
do
  echo "2^$i= $((2**i))"
done*/
    }
}
