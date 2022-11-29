using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class SquareRoot
    {
        public static void Squrt()
        {
            Console.WriteLine("Enter a value: ");
            double X = Convert.ToInt32(Console.ReadLine());

            double SquareRoot = Math.Sqrt(X);
            Console.WriteLine("\nThe Square Root of {0} = {1}", X, SquareRoot);
        }
    }
}
