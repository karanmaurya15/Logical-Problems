using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class PrimeNumber
    {
        public static void PrimeNum()
        {
            int count = 0;
            Console.WriteLine("Enter a value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }
}
