using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            int r = 0;
            while (n > 0)
            {
                if (n % 2 == 1) r++;
                n /= 2;
            }
            Console.WriteLine("Number of 1 bits in : " + n + " is: "+ r);
            return r;
        }
    }
}
