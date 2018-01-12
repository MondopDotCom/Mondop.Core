using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace mondop.core.tests
{
    [TestClass]
    public class EnsureTests
    {
        [TestMethod]
        public void CallWithValidArgument_Expect_AssignedResult()
        {
            var test = new StringBuilder();

            var result = Ensure.IsNotNull(test, nameof(test));

            result.Should().NotBeNull();
        }

        [TestMethod]
        public void CallWith_NullValue_Expect_Exception()
        {
            StringBuilder test = null;
            Action action = () => Ensure.IsNotNull(test, nameof(test));

            action.ShouldThrowExactly<ArgumentNullException>();
        }
    }
}
