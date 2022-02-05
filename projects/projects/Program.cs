using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonocciseries ........
                FibonocciSeries series = new FibonocciSeries();
                series.FindFibonocciSeries();

             //Reverse numbers ......
                ReverseNumbers.FindReverseNumber();
                Console.ReadLine();

             //swapping of two numbers
                SwapNumbers.SwappingNumbers();
             //flipping of coins
                CoinFlip flipCoin = new CoinFlip();
                flipCoin.FlipCoin();
             //check given year is leap year or not
                LeapYear leapYear  = new LeapYear();
                leapYear.LeapYearCheck();
             //print powers of 2
               PowerOfTwo.PrintTable();
             //find value of nth harmonic
               HarmonicNumber.GetHarmonic();
             //get prime factors of given number
              Factors.GetPrimeFactors();
             //find quotient and remainder of given number
              QuotientAndRemainder.GetQuotientRemainder();
             //check number is even or odd
              EvenOdd.EvenOddCheck();
             //check given letter is vowel or consonant
              VowelConsonant.VowelCheck();
             //find largest of three numbers
             LargestNumber largest=new LargestNumber();
             largest.GetLargest();
             //finding perfect number
             PerfectNumber perfectnum = new PerfectNumber();
             perfectnum.Perfect();
            //find prime number
            PrimeNumber primenum = new PrimeNumber();
            primenum.Prime();
            //generate coupon numbers
            CouponNumbers couponNumbers = new CouponNumbers();
            couponNumbers.GetCouponNumbers();
            //stop watch
            StopWatch.ElapsedTime();
            //fewest notes to be returned for vending machine
             VendingMachine vending = new VendingMachine();
            vending.Getchange();
            //find day of week
             DayOfWeek weekday = new DayOfWeek();
             weekday.Day();
             TemperatureConversion temperature = new TemperatureConversion();
              Console.WriteLine("Enter value of temperature ");
              int temp = Convert.ToInt32(Console.ReadLine());
              temperature.temperatureconversion(temp);
            //monthly payment
             MonthlyPayment month = new MonthlyPayment();
             Console.WriteLine("Enter the value of principal");
             double P = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter the year");
             double Y = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter the rate : ");
             double R = Convert.ToDouble(Console.ReadLine());
             month.monthlypayment(P, Y, R);
            //finding square root 
            SquareRoot.Sqrt();
            //decimal to binary conversion
             BinaryConversion binary = new BinaryConversion();
              binary.decimalToBinary();
            SwapNibbles nible = new SwapNibbles();
            Console.WriteLine("Enter number to convert in Binary :");
            int number = Convert.ToInt32(Console.ReadLine());
            nible.ToBinary(number);
            Console.ReadLine();
        }
    }
}
