using System;
using System.Collections.Generic;
using NUnit.Framework;
using Leetcode.Questions;

namespace Leetcode.Tests
{
    public class PascalTriangleTests : TestsBase
    {
        [Test]
        public void PascalTriangleExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => PascalTriangle.Generate(0));
        }

        [Test]

        public void PascalTriangleGenerateTest()
        {
            for (byte i = 1; i < 10; i++)
            {
                IList<IList<int>> list = PascalTriangle.Generate(i);

                Assert.AreEqual(list.Count, i);
                Assert.AreEqual(list[i - 1].Count, i);
            }
        }

        [Test]
        public void PascalTriangleValuesTest()
        {
            IList<IList<int>> list = PascalTriangle.Generate(5);

            Assert.AreEqual(list[0], new List<int> { 1 });
            Assert.AreEqual(list[1], new List<int> { 1, 1 });
            Assert.AreEqual(list[2], new List<int> { 1, 2, 1 });
            Assert.AreEqual(list[3], new List<int> { 1, 3, 3, 1 });
            Assert.AreEqual(list[4], new List<int> { 1, 4, 6, 4, 1 });
        }
    }
}