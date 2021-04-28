using System.Collections.Generic;
using Leetcode.DataStructures;
using NUnit.Framework;

namespace Leetcode.Tests
{
    public class TestsBase
    {
        [SetUp]
        public void Setup()
        {
        }

        protected ListNode ArrayToLinkedList(int[] values)
        {
            ListNode result = null;
            for (int i = values.Length - 1; i >= 0; i--)
            {
                ListNode node = new ListNode(values[i], result);
                result = node;
            }

            return result;
        }

        protected int[] LinkedListToArray(ListNode node)
        {
            List<int> result = new List<int>();

            while (node != null)
            {
                result.Add(node.val);
                node = node.next;
            }

            return result.ToArray();
        }
    }
}
