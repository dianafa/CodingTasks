using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    /* Given a string containing just the characters '(', ')', '{', '}', '[' and ']',
     * determine if the input string is valid. 
     * The brackets must close in the correct order,
     * "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
     */
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (stack.Count == 0) return false;
                    char lol = stack.Pop();
                    if (lol != s[i] - 1 && lol != s[i] - 2) return false;
                }
            }
            if (stack.Count != 0) return false;
            Console.WriteLine("Parentheses string:" + s + "is valid!");
            return true;
        }
    }
}
