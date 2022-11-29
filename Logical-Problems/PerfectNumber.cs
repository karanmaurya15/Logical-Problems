using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class PerfectNumber
    {
        public static void PerfectNum()
        {
            int sum = 0;
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("{0} is a Perfect Number", num);
                
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", num);
            }
        }
    }
}
