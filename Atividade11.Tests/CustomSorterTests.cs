namespace Atividade11.Tests
{
    public class CustomSorterTests
    {
        [Fact]
        public void SortDescending_WithValidList_ReturnSortDescendingList()
        {
            var sorter = new CustomSorter();
            var numbers = new List<int> { 3, 5, 1, 4, 2 };

            var result = sorter.SortDescending(numbers);

            Assert.Equal(result, new List<int> { 5, 4, 3, 2, 1 });
        }
    }
}
