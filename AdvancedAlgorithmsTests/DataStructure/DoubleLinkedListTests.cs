using AdvancedAlgorithms.DataStructure.DoubleLinkedList;
using Xunit;

namespace AdvancedAlgorithmsTests.DataStructure
{
    public class DoubleLinkedListTests
    {
        public DoubleLinkedListTests()
        {

        }

        [Fact]
        public void Shold_add_an_element_at_first_position()
        {
            var list = new DoubleLinkedList<int>();
            list.SetHead(5);
            list.SetHead(4);
            list.SetHead(3);
            list.SetHead(2);
            list.SetHead(1);

            Assert.True(list.GetFirst().value == 1);
        }

        [Fact]
        public void Shold_add_an_element_at_last_position()
        {
            var list = new DoubleLinkedList<int>();
            list.SetTail(5);
            list.SetTail(4);
            list.SetTail(3);
            list.SetTail(2);
            list.SetTail(1);

            Assert.True(list.GetLast().value == 1);
        }
    }
}
