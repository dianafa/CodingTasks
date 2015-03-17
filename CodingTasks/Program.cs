using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PascalsTriangle PT = new PascalsTriangle();
            PT.Generate(9);
            RomanToInteger RTI = new RomanToInteger();
            RTI.RomanToInt("XVII");
            ValidParentheses VP = new ValidParentheses();
            VP.IsValid("{[][({})]}");
            VP.IsValid("[{(})]");
            NumberOf1Bits NO1B = new NumberOf1Bits();
            NO1B.HammingWeight(11);
            ReverseBits RB = new ReverseBits();
            RB.reverseBits(43261596);

            Console.ReadLine();
        }
    }
}
