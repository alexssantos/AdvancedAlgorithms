using System;

namespace AdvancedAlgorithms.Searching
{

    /* Estrategia: Dividir e Conquistar. */

    public static class BinarySearch
    {
        /**
        * Busca recursivamente o item dentro do vetor vector. A cada iteração
        * reduz o espaço de busca pela metade. Quando encontra o item retorna
        * o índice onde ele foi encontrado. Caso contrário retorna -1
        */
        public static int Execute<T>(T[] vetor, int indiceInicio, int indiceFim, T valor) where T : IComparable
        {
            /* Índice representando o meio do sub-vetor begin->end */
            int posicaoPivo = (indiceInicio + indiceFim) / 2;

            /* Ponto de parada. Item não está no vetor */
            if (indiceInicio > indiceFim)
                return -1;

            int resultado = valor.CompareTo(vetor[posicaoPivo]);

            if (resultado == 0) /* Valor encontrado */
            {
                return posicaoPivo;
            }
            else if (resultado < 0) /* Se o valor é menor que o valor na posição Pivô, Item está no sub-vetor à esquerda */
            {
                return Execute(vetor, indiceInicio, posicaoPivo - 1, valor);
            }
            else  /* Se o valor é MAIOR que o valor na posição Pivô, Item está no sub-vetor à direita */
            {
                return Execute(vetor, posicaoPivo + 1, indiceFim, valor);
            }
        }
    }
}
