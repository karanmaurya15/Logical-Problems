using System.Diagnostics;

namespace Logical_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~Fibonacci series~~~~~~~~~~~~");
            FibonacciSeries.Fibonacci();

            Console.WriteLine("\n~~~~~~~~~~~~~~Perfect Number~~~~~~~~~~~~");
            PerfectNumber.PerfectNum();

            Console.WriteLine("\n~~~~~~~~~~~~Prime Number~~~~~~~~~~~~~~~~");
            PrimeNumber.PrimeNum();

            Console.WriteLine("\n~~~~~~~~~~~~~~Reverse Number~~~~~~~~~~~~");
            ReverseNumber.ReverseNum();

            Console.WriteLine("\n~~~~~~~~~~~~~~Coupon Number~~~~~~~~~~~~~");
            CouponNumber.CouponNum();

            Console.WriteLine("\n~~~~~~~~~~~~~~Stop Watch~~~~~~~~~~~~~~~~");
            StopWatch.Stopwatch();

        }
    }
}