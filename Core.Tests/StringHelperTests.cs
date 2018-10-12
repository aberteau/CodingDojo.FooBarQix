using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo.FooBarQix.Core.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [DataTestMethod]
        [DataRow("1","1")]
        [DataRow("2","2")]
        [DataRow("3", "FooFoo")]
        [DataRow("4", "4")]
        [DataRow("5", "BarBar")]
        [DataRow("6", "Foo")]
        [DataRow("7", "QixQix")]
        [DataRow("8", "8")]
        [DataRow("9", "Foo")]
        [DataRow("10", "Bar")]
        [DataRow("13", "Foo")]
        [DataRow("15", "FooBarBar")]
        [DataRow("21", "FooQix")]
        [DataRow("33", "FooFooFoo")]
        [DataRow("51", "FooBar")]
        [DataRow("53", "BarFoo")]
        public void ShouldComputeRespectStep1(String input, String result)
        {
            string computedResult = StringHelper.Compute(input);
            Assert.AreEqual(result, computedResult);
        }

        [DataTestMethod]
        [DataRow("101", "1*1")]
        [DataRow("303", "FooFoo*Foo")]
        [DataRow("105", "FooBarQix*Bar")]
        [DataRow("10101", "FooQix**")]
        public void ShouldComputeRespectStep2(String input, String result)
        {
            string computedResult = StringHelper.Compute(input);
            Assert.AreEqual(result, computedResult);
        }
    }
}
