using System;
using System.Linq;

namespace AdvancedAlgorithmsTests.Utils
{
    public class CollectionsUtils
    {
        public static int[] GerarListaAleatoria(int quantidade, int minumo, int maximo)
        {
            var vetor = new int[quantidade];
            var sequencia = Enumerable.Range(0, quantidade - 1);
            foreach (var indice in sequencia)
            {
                Random rnd = new Random();
                vetor[indice] = rnd.Next(minumo, maximo);
            }
            return vetor;
        }
    }
}
