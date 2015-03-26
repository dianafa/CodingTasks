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

            AddTwoNumbers ATN = new AddTwoNumbers();
            ListNode la1 = new ListNode(2);
            ListNode la2 = new ListNode(4);
            ListNode la3 = new ListNode(3);
            ListNode lb1 = new ListNode(5);
            ListNode lb2 = new ListNode(6);
            ListNode lb3 = new ListNode(4);
            ListNode lb4 = new ListNode(9);
            la1.next = la2;
            la2.next = la3;
            lb1.next = lb2;
            lb2.next = lb3;
            lb3.next = lb4;
            ATN.AddsTwoNumbers(la1, lb1);
            ATN.AddsTwoNumbers(new ListNode(1), new ListNode(1));

            Console.ReadLine();
        }
    }
}
