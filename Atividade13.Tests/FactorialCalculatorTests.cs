namespace Atividade13.Tests
{
    public class FactorialCalculatorTests
    {
        [Fact]
        public void Calculate_EnterNegativeNumber_ThrowsArgumentException()
        {
            var calculator = new FactorialCalculator();
            
            var exception = Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
            Assert.Equal("Number must be non-negative", exception.Message);
        }

        [Fact]
        public void Calculate_EnterNumberZero_Return1()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(0);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_EnterNumberOne_Return1()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Calculate_EnterNumberGreaterThenOne_ReturnFactorial()
        {
            var calculator = new FactorialCalculator();

            var result = calculator.Calculate(5);
            Assert.Equal(120, result);
        }
    }
}
