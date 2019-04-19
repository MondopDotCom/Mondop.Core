using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Mondop.Core.Tests
{
    [TestClass]
    public class IEnumerableStringExentionsTests
    {
        [TestMethod]
        public void CallJoin_WithNull_Expect_Null()
        {
            string[] temp = null;
            var result = temp.Join(",");

            result.Should().BeNull();
        }

        [TestMethod]
        public void CallJoin_WithNullSeparation_Expect_ArgumentNullException()
        {
            Action action = () => { new string[] { "A", "B", "C" }.Join(null); };

            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [TestMethod]
        public void CallJoin_WithCorrectParametes_Expect_JoinedString()
        {
            var array = new string[] { "A", "B", "C" };

            var result = array.Join("x");
            result.Should().Be("AxBxC");
        }
    }
}
