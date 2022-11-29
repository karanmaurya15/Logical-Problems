using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class MonthlyPayment
    {
        public static void MPayment()
        {
            Console.WriteLine("Enter Principal amount in Rs.: ");
            double P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Year to pay off principal amount: ");
            double Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Rate of interest compounded monthly: ");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            Console.WriteLine("The monthly payment to be paid for {0} years for a principle amount of Rs.{1} at {2}% interest compounded monthly is: Rs.{3}", Y, P, R, payment);
        }
    }
}
