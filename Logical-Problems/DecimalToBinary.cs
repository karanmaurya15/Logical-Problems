using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class DecimalToBinary
    {
        public static void DecimalBinary()
        {
            Console.WriteLine("Enter the Decimal Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] numberArray = new int[10]; //The Decimal numbers are the numbers whose base is 10. That means the decimal numbers range from 0 to 9.
            for (i = 0; num > 0; i++)
            {
                numberArray[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("\nBinary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
        }
    }
}
