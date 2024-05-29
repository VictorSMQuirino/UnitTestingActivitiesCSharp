namespace Atividade09.Tests
{
    public class ItemCollectionTests
    {
        [Fact]
        public void AddItem_WithNotNullItem_CollectionContainsItem()
        {
            var item = new Item("Exemplo");
            var items = new ItemCollection();

            items.AddItem(item);

            Assert.Contains(item, items.GetItems());
        }

        [Fact]
        public void AddItem_WithNullItem_ThrowsArgumentException()
        {
            var items = new ItemCollection();

            var exception = Assert.Throws<ArgumentException>(() => items.AddItem(null));
            Assert.Equal(exception.Message, "Item cannot be null");
        }

        [Fact]
        public void RemoveItem_WithItemInCollection_ColelctionNotContainsItem()
        {
            var item = new Item("Exemplo");
            var items = new ItemCollection();

            items.AddItem(item);
            items.RemoveItem(item);

            Assert.DoesNotContain(item, items.GetItems());
        }

        [Fact]
        public void RemoveItem_WithItemNotInCollection_ThrowsArgumentException()
        {
            var item = new Item("Exemplo");
            var items = new ItemCollection();

            var exception = Assert.Throws<ArgumentException>(() => items.RemoveItem(item));
            Assert.Equal(exception.Message, "Item not found in the collection");
        }

        [Fact]
        public void GetItems_FromAnEmptyList_ReturnsItemsEmptyList()
        {
            var items = new ItemCollection();

            var list = items.GetItems();

            Assert.Empty(list);
            Assert.IsType<List<Item>>(list);
        }

        [Fact]
        public void GetItems_FromAnNotEmptyList_ReturnsItemsList()
        {
            var items = new ItemCollection();
            items.AddItem(new Item("Exemplo1"));
            items.AddItem(new Item("Exemplo2"));
            items.AddItem(new Item("Exemplo3"));
            items.AddItem(new Item("Exemplo4"));
            items.AddItem(new Item("Exemplo5"));

            var list = items.GetItems();

            Assert.NotEmpty(list);
            Assert.IsType<List<Item>>(list);
        }
    }
}