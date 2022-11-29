using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class SwapNibble
    {
        public static int swapNibbles(int x)
        {
            return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
        }
    }
}
