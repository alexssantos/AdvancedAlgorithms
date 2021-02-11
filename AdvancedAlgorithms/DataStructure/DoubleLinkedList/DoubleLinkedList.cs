using System;

namespace AdvancedAlgorithms.DataStructure.DoubleLinkedList
{
    public class DoubleLinkedList<V>
    {
        // seu PREVIOUS sempre deve ser NULL
        private Node<V> Head { get; set; }
        // seu NEXT sempre deve ser NULL
        private Node<V> Tail { get; set; }

        public int Size { get; private set; }


        public DoubleLinkedList(Node<V> head = null, Node<V> tail = null)
        {
            this.Head = head;
            this.Tail = tail;
            head.next = tail;
            tail.previous = head;
            Size = 2;
        }

        private void SetFirstItem(Node<V> node)
        {
            node.previous = null;
            node.next = null;
            Head = node;
            Tail = node;
            Size = 1;
        }

        public void SetHead(V value) => SetHead(new Node<V>(value));
        public void SetHead(Node<V> first)
        {
            if (IsEmpty())
                SetFirstItem(first);
            else
            {
                //configura como primeiro nó
                first.previous = null;

                //transferindo ponteiro do nó
                first.next = Head;
                if (Head != null)
                    Head.previous = first;

                //atualiza o apontando para o primeiro.
                Head = first;

                if (Size == 1)
                {
                    Tail = first.next;
                }
                Size += 1;
            }
        }

        public void SetTail(V value) => SetTail(new Node<V>(value));
        public void SetTail(Node<V> last)
        {
            if (IsEmpty())
                SetFirstItem(last);
            else
            {
                //configura como ultimo.
                last.next = null;

                //transferindo ponteiro
                last.previous = Tail;
                if (Tail != null)
                    Tail.next = last;

                //atualiza ponteiro para o correto.
                Tail = last;
                if (Size == 1)
                {
                    Head = last.previous;
                }
                Size += 1;
            }
        }

        public void AddAfterValue(V target, V value)
        {
            InsertRight(
                SearchFirstOne(target),
                new Node<V>(value));
        }

        public void AddBeforeValue(V target, V value)
        {
            InsertBefore(
                SearchFirstOne(target),
                new Node<V>(value));
        }


        public Node<V> SearchFirstOne(V value)
        {
            var pointer = Head;
            while (!pointer.value.Equals(value))
                pointer = pointer.next;

            return pointer;
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
                throw new ArgumentException("A lista já esta vazia.");

            //aponta pro proximo
            Head = Head.next;
            //configura o atual head como primeiro.
            Head.previous = null;
            Size -= 1;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new ArgumentException("A lista já esta vazia.");

            //aponta pro anterior
            Tail = Tail.previous;
            //configura como ultimo.
            Tail.next = null;
            Size -= 1;
        }

        private bool IsEmpty()
        {
            return Head == null;
        }


        public Node<V> GetFirst() => Head;

        public Node<V> GetLast() => Tail;

        private void InsertBefore(Node<V> target, Node<V> newNode)
        {
            if (Size == 1 || Head.Equals(target))
            {
                SetHead(newNode);
            }
            else
            {
                var founded = SearchFirstOne(target.value);
                var prev = founded.previous;

                prev.next = newNode;
                newNode.previous = prev;

                founded.previous = newNode;
                newNode.next = founded;
            }
        }

        private void InsertRight(Node<V> target, Node<V> newNode)
        {
            if (Size == 1 || Tail.Equals(target))
            {
                SetTail(newNode);
            }
            else
            {
                var founded = SearchFirstOne(target.value);
                var next = founded.next;

                newNode.next = next;
                next.previous = newNode;

                newNode.previous = founded;
                founded.next = newNode;
            }
        }


        //********************************** PRINT ****************************************

        public void PrintLinkedListForward()
        {
            Console.WriteLine("Printing Doubly LinkedList (head --> tail) ");

            //pega o primeiro
            Node<V> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.next;
            }
            Console.ReadKey();
        }

        public void PrintLinkedListBackward()
        {
            Console.WriteLine("Printing Doubly LinkedList (head --> tail) ");

            //pega o primeiro
            Node<V> current = Tail;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.previous;
            }
            Console.ReadKey();
        }

        public override string ToString()
           => $"valor: {Head.value}";

    }
}
