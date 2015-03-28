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

            SumRootToLeafNumbers SRTLN = new SumRootToLeafNumbers();
            TreeNode root = new TreeNode(5);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);

            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n1.right = n4;
            n2.left = n5;

            SRTLN.SumNumbers (root);

            TreeNode r = new TreeNode(6);
            TreeNode n6 = new TreeNode(4);
            TreeNode n7 = new TreeNode(6);
            TreeNode n8 = new TreeNode(4);
            TreeNode n9 = new TreeNode(2);
            TreeNode n10 = new TreeNode(6);
            TreeNode n11 = new TreeNode(1);

            r.left = n6;
            n6.left = n7;
            n7.right = n8;
            n8.left = n9;
            n9.left = n10;
            r.right = n11;

            SRTLN.SumNumbers(r);
            Console.ReadLine();
        }
    }
}
