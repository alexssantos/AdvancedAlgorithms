using System;

namespace AdvancedAlgorithms.Searching
{
    public static class SequentialSearch
    {
        public static int Execute<T>(T[] vetor, int tamanho, T valor) where T : IComparable
        {
            for (int indice = 0; indice < tamanho; indice++)
            {
                if (vetor[indice].CompareTo(valor) == 0)
                {
                    return indice;
                }
            }
            return -1;
        }
    }
}
