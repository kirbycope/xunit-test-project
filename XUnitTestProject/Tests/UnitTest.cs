/* 
 * Referenced Code Example:
 *   https://xunit.net/docs/getting-started/netfx/visual-studio
 *   Getting Started with xUnit.net
 *   Copyright © 2019 .NET Foundation
 */

using Xunit;

namespace XUnitTestProject.Tests
{
    public class UnitTest
    {
        #region Test Methods

        // Facts are tests which are always true. They test invariant conditions.
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        // Theories are tests which are only true for a particular set of data.
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        #endregion Test Methods

        #region Utility Methods

        private int Add(int x, int y)
        {
            return x + y;
        }

        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        #endregion Utility Methods
    }
}
