using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project;

namespace Project
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
namespace NUnit
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldReturnSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
