using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class FibonacciSeries
    {
        public static void Fibonacci()
        {

            Console.WriteLine("Enter N terms for the Fibonaccis Series: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("The Fibonacci Series for {0} terms are: ", N);
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < (N - 2); i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    } 
}

