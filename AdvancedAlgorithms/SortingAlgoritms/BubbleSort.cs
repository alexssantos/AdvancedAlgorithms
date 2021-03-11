namespace AdvancedAlgorithms.SortingAlgoritms
{
    public class BubbleSort
    {
        public static int[] Execute(int[] lista)
        {
            int tamanho = lista.Length;
            int comparacoes = 0;
            int trocas = 0;

            //i é a ultima posição.
            for (int i = (tamanho - 1); i >= 1; i--)
            {
                //J percorre de 0 até a posição i (ultima)
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (lista[j] > lista[j + 1])
                    {
                        trocas++;
                        int aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }
            return lista;
        }
    }
}
