using AdvancedAlgorithms.Searching;
using Xunit;

namespace AdvancedAlgorithmsTests.Searching
{
    public class BinarySearchingTests
    {
        [Fact]
        public void encontra_item_por_busca_binaria()
        {
            int[] array = new int[] { 1, 7, 9, 15, 19, 21, 23, 24, 31, 35, 41 };
            var indice = BinarySearch.Execute(array, 0, array.Length - 1, 19);

            var indiceEsperado = 4;
            Assert.Equal(indiceEsperado, indice);
        }
    }
}
