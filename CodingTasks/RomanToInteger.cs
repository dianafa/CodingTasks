using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class RomanToInteger
    {
        Dictionary<char, int> roman = new Dictionary<char, int>();

        public int RomanToInt(string s)
        {

            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            int result = 0;
            char tmp, tmp2;
            int sign, sign2;
            for (int i = 0; i < s.Length; i++)
            {
                tmp = s[i];
                sign = roman[tmp];

                //if it is not the last sign
                if (i < s.Length - 1)
                {
                    tmp2 = s[i + 1];
                    sign2 = roman[tmp2];
                    if (sign < sign2)
                    {
                        result += sign2 - sign;
                        ++i;
                    }
                    else
                    {
                        result += sign;
                    }
                }
                else//this is the last sign
                {
                    result += sign;
                }
            }
            Console.WriteLine("Roman " + s + " is: " + result);
            return result;
        }
    }
}
