using NUnit.Framework;
using NUnit.Framework.Legacy; // Ensure NUnit framework is referenced

namespace CalcuMyProject
{
    public class Tests
    {
        private Calculator _calculator; // Declare an instance of the Calculator class

        [SetUp]
        public void Setup()
        {
            // Initialize the Calculator instance before each test
            _calculator = new Calculator();
        }

        [Test]
        public void AddTwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var num1 = 2;
            var num2 = 3;

            // Act
            int result = _calculator.AddNumber(num1, num2);

            // Assert
           ClassicAssert.AreEqual(result, num1 + num2);
        }
    }

    public class Calculator
    {
        public int AddNumber(int a, int b)
        {
            return a + b; // Perform addition
        }
    }
}