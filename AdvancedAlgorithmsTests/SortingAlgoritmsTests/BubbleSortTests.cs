using AdvancedAlgorithms.SortingAlgoritms;
using AdvancedAlgorithmsTests.Utils;
using System.Linq;
using Xunit;

namespace AdvancedAlgorithmsTests.SortingAlgoritmsTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void Deve_ordenar_um_vetor_usando_bubbleSorte()
        {
            var vetor = CollectionsUtils.GerarListaAleatoria(10, 1, 10);
            var esperado = vetor.ToList();
            esperado.Sort();

            BubbleSort.Execute(vetor);

            Assert.Equal(vetor, esperado.ToArray());
        }
    }
}
