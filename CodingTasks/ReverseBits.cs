using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    /*
     * Reverse bits of a given 32 bits unsigned integer.
     */
    class ReverseBits
    {
        public uint reverseBits(uint n) {
            uint r = 0;
            uint m = (uint)Math.Pow(2, 31);
            
            while (n > 0)
            {
                if (n % 2 == 1) {
                    r += m;
                }
                n >>= 1;
                m >>= 1;
            }
            Console.WriteLine("Reversed number: " + r);
            return r;
        }
    }
}
