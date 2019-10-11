using System;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbers_ValidValues_ReturnsCorrectResult()
        {
            var sut = new Calculator();
            int result = sut.AddNumbers(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }

    
    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}