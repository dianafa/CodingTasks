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
            int[] tab = new int[100];
            tab[0] = root.val;
            int i = 0;
            GO(null, root, tab, 1);
            return 0;
        }

        void GO(TreeNode prev, TreeNode current, int[] tab, int i)
        {
            if (current.left != null)
            {
                tab[i] = current.val;
                GO(current, current.left, tab, i++);
            }
            else if (current.right != null)
            {
                tab[i] = current.val;
                GO(current, current.right, tab, i++);
            }
            else //both left and right is equal to null
            {
                tab[i] = current.val;
                ComputeSum(tab);
                i--;
            }
        }

        public int ComputeSum(int[] tab)
        {
            int result = 0;
            int dec = 1;
            for (int i = tab.Length -1; i >= 0; --i)
            {
                result += dec * tab[i];
                dec *= 10;
            }
            return result;
        }
    }
}
