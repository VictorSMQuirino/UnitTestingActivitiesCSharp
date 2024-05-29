namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_WithValidList_ReturnListAverage()
        {
            var numbers = new List<int> { 10, 15, 20, 30 };
            var statistic = new Statistics();

            var average = statistic.CalculateAverage(numbers);

            Assert.Equal(average, 18.75);
        }

        [Fact]
        public void CalculateAverage_WithNullList_ThrowsArgumentException()
        {
            var statistic = new Statistics();

            var exception = Assert.Throws<ArgumentException>(() => statistic.CalculateAverage(null));
            Assert.Equal(exception.Message, "The list of numbers cannot be empty");
        }

        [Fact]
        public void CalculateAverage_WithEmptyList_ThrowsArgumentException()
        {
            var numbers = new List<int>();
            var statistic = new Statistics();

            var exception = Assert.Throws<ArgumentException>(() => statistic.CalculateAverage(numbers));
            Assert.Equal(exception.Message, "The list of numbers cannot be empty");
        }
    }
}