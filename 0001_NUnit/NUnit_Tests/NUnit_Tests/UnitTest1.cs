using NUnit.Framework;
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

namespace NUnit_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddShouldReturnSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}