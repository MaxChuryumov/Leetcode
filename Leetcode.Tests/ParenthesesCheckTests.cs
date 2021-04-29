using NUnit.Framework;
using Leetcode.Questions;

namespace Leetcode.Tests
{
    public class ParenthesesCheckTests : TestsBase
    {
        [Test]
        public void ParenthesesCheckTest()
        {
            Assert.IsTrue(ParenthesesCheck.Check("[()]{ }"));
            Assert.IsTrue(ParenthesesCheck.Check("[{[()()]()}"));
            Assert.IsFalse(ParenthesesCheck.Check("[(])"));
        }
    }
}
