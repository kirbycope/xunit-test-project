/* 
 * Referenced Code Example:
 *   https://xunit.net/docs/shared-context
 *   Shared Context between Tests
 *   Copyright © 2019 .NET Foundation
 */

using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject.Tests
{
    public class SetupAndTeardown : IDisposable
    {
        #region Test Setup and Teardown

        /// <summary>
        /// A example of a variable that is used in each Test (Fact/Theory) but it's value is reset with each test.
        /// </summary>
        private readonly Stack<int> stack;

        /// <summary>
        /// xUnit.net creates a new instance of the test class for every test that is run, so any code which is placed
        /// into the constructor of the test class will be run for every single test.<br />
        /// This makes the constructor a convenient place to put reusable context setup code where you want to share
        /// the code without sharing object instances.<br />
        /// Meaning, you get a clean copy of the context object(s) for every test that is run.
        /// </summary>
        /// <remarks>
        /// Equivalent in MSTest: [TestInitialize]
        /// Equivalent in NUnit: [SetUp]
        /// </remarks>
        public SetupAndTeardown()
        {
            // Instantiate the stack variable
            stack = new Stack<int>();
        }

        /// <summary>
        /// For context cleanup, add the IDisposable interface to your test class, and put the cleanup code in the
        /// Dispose() method.
        /// </summary>
        /// <remarks>
        /// Equivalent in MSTest: [TestCleanup]
        /// Equivalent in NUnit: [TearDown]
        /// </remarks>
        public void Dispose()
        {
            //stack.Dispose();
            stack.Clear();
        }

        #endregion Test Setup and Teardown

        #region Test Methods

        [Fact]
        public void WithNoItems_CountShouldReturnZero()
        {
            // Get the count of objects in the stack
            var count = stack.Count;
            // Assert that the value is expected
            Assert.Equal(0, count);
        }

        [Fact]
        public void AfterPushingItem_CountShouldReturnOne()
        {
            // Insert a value (42) at the top of the stack
            stack.Push(42);
            // Get the count of objects in the stack
            var count = stack.Count;
            // Assert that the value is expected
            Assert.Equal(1, count);
        }

        #endregion Test Methods
    }
}
