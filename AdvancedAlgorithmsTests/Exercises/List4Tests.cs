using AdvancedAlgorithms.DataStructure.DoubleLinkedList;
using Xunit;


/*
        1 - ALTERAR O CODIGO DA LISTA DUPLAMENTE ENCADEADA E ADICIONAR OS SEGUINTE METODOS:
           - Buscar um determinado nó pelo valor
           - Inserir um valor (Append) após um nó
           - Remover um nó pelo valor

         2 - CRIAR UMA LISTA DUPLAMENTE ENCADEADA CIRCULAR COM O METODOS:
            - ADICIONAR PELO HEAD
            - ADICIONAR PELO TAIL
            - REMOVER PELO HEAD
            - REMOVER PELO TAIL
            - BUSCAR
            - IMPRIMIR A LISTA PELO HEAD
            - IMPRIMIR A LISTA PELO TAIL
            - EXIBIR O TAMANHO DA LISTA
         
*/


namespace AdvancedAlgorithmsTests.Exercises
{
    public class List4Tests
    {

        public List4Tests()
        {

        }


        //Buscar um determinado nó pelo valor
        [Fact]
        public void Exercise1Item1()
        {
            var list = new DoubleLinkedList<int>(new Node<int>(1), new Node<int>(2));
            list.SetTail(3);
            list.SetTail(4);
            list.SetTail(5);

            Assert.Equal(5, list.SearchFirstOne(5).value);
        }

        //Inserir um valor (Append) após um nó
        [Fact]
        public void Exercise1Item2()
        {
            var list = new DoubleLinkedList<int>(
                new Node<int>(1),
                new Node<int>(2));
            list.SetTail(3);
            list.SetTail(4);
            list.SetTail(5);

            list.AddAfterValue(4, 10);
            var nodeValue4 = list.SearchFirstOne(4);

            Assert.Equal(10, nodeValue4.next.value);
        }

        //Remover um nó pelo valor
        [Fact]
        public void Exercise1Item3()
        {

        }

        [Fact]
        public void Exercise2Item1()
        {

        }
    }
}
