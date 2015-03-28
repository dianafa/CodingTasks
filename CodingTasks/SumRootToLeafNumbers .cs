using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    /**
     * Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
     * An example is the root-to-leaf path 1->2->3 which represents the number 123.
     * Find the total sum of all root-to-leaf numbers.
     */

    public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
    }

    public class SumRootToLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;

            List<int> numbers = new List<int>();
            int ss = 0;
            GO(root, numbers, ref ss);
            Console.WriteLine("The sum of paths is: " + ss);
            return ss;
        }

        void GO(TreeNode current, List<int> numbers, ref int ss)
        {
            numbers.Add(current.val);
            if (current.left == null && current.right == null)
            {
                ss += ComputeSum(numbers);
            }
            else
            {
                if (current.left != null)
                {
                    GO(current.left, numbers, ref ss);
                }
                if (current.right != null)
                {
                    GO(current.right, numbers, ref ss);
                }
            }
            numbers.RemoveAt(numbers.Count -1);
        }

        public int ComputeSum(List<int> numbers)
        {
            int result = 0;
            int dec = 1;
            for (int i = numbers.Count - 1; i >= 0; --i)
            {
                result += dec * numbers[i];
                dec *= 10;
            }
            return result;
        }
    }
}
