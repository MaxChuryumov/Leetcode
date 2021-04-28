
// You are given two non-empty linked lists representing two non-negative integers. 
// The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

// Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
// Output:[7,0,8]
// Explanation: 342 + 465 = 807.

// Example 2:
// Input: l1 = [0], l2 = [0]
// Output:[0]

// Example 3:
// Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
// Output:[8,9,9,9,0,0,0,1]

using Leetcode.DataStructures;
using System;

namespace Leetcode.Questions
{
    public static class AddTwoNumbers
    {
        public static ListNode Calulate(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode l3 = null;

            int z = 0;
            while (l1 != null || l2 != null)
            {
                if (result == null)
                {
                    l3 = new ListNode();
                    result = l3;
                }
                else
                {
                    l3.next = new ListNode();
                    l3 = l3.next;
                }

                int x = 0, y = 0;
                if (l1 != null)
                {
                    x = l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    y = l2.val;
                    l2 = l2.next;
                }

                if (x + y + z > 9)
                {
                    l3.val = x + y + z - 10;
                    z = 1;
                }
                else
                {
                    l3.val = x + y + z;
                    z = 0;
                }
            }

            if (z == 1)
                l3.next = new ListNode(z);

            return result;
        }

        public static void Print(ListNode list)
        {
            
            while (list != null)
            {
                Console.Write(list.val + "\t");
                list = list.next;
            }
        }
    }
}