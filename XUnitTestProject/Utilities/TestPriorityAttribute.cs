/* 
 * Referenced Code Example:
 *   https://github.com/xunit/samples.xunit/blob/master/TestOrderExamples/TestCaseOrdering/TestPriorityAttribute.cs
 *   TestPriorityAttribute.cs
 *   Copyright © 2019 .NET Foundation
 */

using System;

namespace XUnitTestProject.Utilities
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestPriorityAttribute : Attribute
    {
        public TestPriorityAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; private set; }
    }
}
