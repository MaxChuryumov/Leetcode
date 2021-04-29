//Given an expression string exp, write a program to examine whether the pairs and the orders of “{“, “}”, “(“, “)”, “[“, “]” are correct in exp.

//Example: 

//Input: exp = “[()]{ }"
//{[()()]()}” 
//Output: Balanced

//Input: exp = “[(])” 
//Output: Not Balanced

using Leetcode.DataStructures;

namespace Leetcode.Questions
{

    public static class ParenthesesCheck
    {
        public static bool Check(string input)
        {
            ListNode node = null;
            foreach (char c in input)
            {
                int charIndex = brackets.IndexOf(c);
                if (charIndex % 2 == 0) //open bracket
                {
                    ListNode newNode = new ListNode(c, node);
                    node = newNode;
                }
                else if (charIndex % 2 == 1) //close bracket
                {
                    if (node == null || brackets[charIndex - 1] != node.val)
                        return false;

                    node = node.next;
                }
            }

            return true;
        }

        private static string brackets = "(){}[]<>";
    }
}
