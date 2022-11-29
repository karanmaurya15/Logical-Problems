using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            Console.WriteLine("Enter a number to reverse: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int remainder;

            while (n != 0)
            {
                remainder = n % 10;
                result = (result * 10) + remainder;
                n = n / 10;  //quotient
            }
            Console.WriteLine("The reverse is: " + result);
        }
    }
}
