using Calculator;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        private readonly Calculator.Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator.Calculator();
        }

        [Fact]
        public void SumShouldAddTwoPositiveNumbersAndGetPositiveResult_PositiveTest()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Sum(a, b);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void SumShouldAddTwoPositiveNumbersAndGetPositiveResult_NegativeTest()
        {
            // Arrange
            int a = Int32.MaxValue;
            int b = 3;

            // Act
            int result = _calculator.Sum(a, b);

            // Assert
            Assert.False(result > 0);
        }
    }
}