using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    /*
     * You are given two linked lists representing two non-negative numbers.
     * The digits are stored in reverse order and each of their nodes contain a single digit.
     * Add the two numbers and return it as a linked list.
     * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4 -> 9)
     * Output: 7 -> 0 -> 8 -> 9
     */

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class AddTwoNumbers
    {
        public ListNode AddsTwoNumbers(ListNode l1, ListNode l2) {
            ListNode list = new ListNode(-1);
            ListNode result = list;
            int tmp = 0;

            while (l1 != null || l2 != null || tmp > 0)
            {
                if (l1 == null) l1 = new ListNode(0);
                if (l2 == null) l2 = new ListNode(0);

                int sum = l1.val + l2.val + tmp;
                tmp = 0;
                ListNode node3 = new ListNode(sum % 10);
                tmp = sum / 10;
                l1 = l1.next;
                l2 = l2.next;

                if (list.val == -1)
                {
                    list = node3;
                    result = list;
                }
                else
                {
                    list.next = node3;
                    list = list.next;
                }
            }
            printResult(result);
            return result;
        }

        public void printResult(ListNode list)
        {
            while (list.next != null)
            {
                Console.Write(list.val + " -> ");
                list = list.next;
            }
            Console.WriteLine(list.val);
        }
    }
}
