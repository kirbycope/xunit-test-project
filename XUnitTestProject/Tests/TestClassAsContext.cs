/* 
 * Referenced Code Example:
 *   https://xunit.net/docs/shared-context
 *   Shared Context between Tests
 *   Copyright © 2019 .NET Foundation
 */

using Xunit;

namespace XUnitTestProject.Tests
{
    public class TestClassAsContext
    {
        #region Test Context

        /// <summary>
        /// A example of a variable that is used in each Test (Fact/Theory) but it's value is reset with each test.
        /// </summary>
        private bool flag;

        #endregion Test Context

        #region Test Methods

        [Fact]
        public void PassingTest()
        {
            // Set the "flag" to true
            flag = true;
            // Assert that the value is expected
            Assert.True(flag);
        }

        [Fact]
        public void FailingTest()
        {
            // Set the "flag" to false
            flag = false;
            // Assert that the value is expected
            Assert.True(flag);
        }

        #endregion Test Methods
    }
}
