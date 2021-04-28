using Leetcode.DataStructures;
using Leetcode.Questions;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class AddTwoNumbersTests : TestsBase
    {
        [Test]
        public void AddTwoNumbersTest()
        {
            ListNode l1 = ArrayToLinkedList(new[] { 2, 4, 3 });
            ListNode l2 = ArrayToLinkedList(new[] { 5, 6, 4 });
            ListNode result = AddTwoNumbers.Calulate(l1, l2);
            Assert.AreEqual(LinkedListToArray(result), new[] { 7, 0, 8 });

            l1 = ArrayToLinkedList(new[] { 0 });
            l2 = ArrayToLinkedList(new[] { 0 });
            result = AddTwoNumbers.Calulate(l1, l2);
            Assert.AreEqual(LinkedListToArray(result), new[] { 0 });

            l1 = ArrayToLinkedList(new[] { 9, 9, 9, 9, 9, 9, 9 });
            l2 = ArrayToLinkedList(new[] { 9, 9, 9, 9 });
            result = AddTwoNumbers.Calulate(l1, l2);
            Assert.AreEqual(LinkedListToArray(result), new[] { 8, 9, 9, 9, 0, 0, 0, 1 });

            result = AddTwoNumbers.Calulate(l2, l1);
            Assert.AreEqual(LinkedListToArray(result), new[] { 8, 9, 9, 9, 0, 0, 0, 1 });
        }
    }
}
