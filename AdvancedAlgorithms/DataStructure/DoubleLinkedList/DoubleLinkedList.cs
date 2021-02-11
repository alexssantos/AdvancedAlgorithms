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
            head.Next = tail;
            tail.Previous = head;
            Size = 2;
        }

        private void SetFirstItem(Node<V> node)
        {
            node.Previous = null;
            node.Next = null;
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
                first.Previous = null;

                //transferindo ponteiro do nó
                first.Next = Head;
                if (Head != null)
                    Head.Previous = first;

                //atualiza o apontando para o primeiro.
                Head = first;

                if (Size == 1)
                {
                    Tail = first.Next;
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
                last.Next = null;

                //transferindo ponteiro
                last.Previous = Tail;
                if (Tail != null)
                    Tail.Next = last;

                //atualiza ponteiro para o correto.
                Tail = last;
                if (Size == 1)
                {
                    Head = last.Previous;
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
            while (!pointer.Value.Equals(value))
                pointer = pointer.Next;

            return pointer;
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
                throw new ArgumentException("A lista já esta vazia.");

            //aponta pro proximo
            Head = Head.Next;
            //configura o atual head como primeiro.
            Head.Previous = null;
            Size -= 1;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new ArgumentException("A lista já esta vazia.");

            //aponta pro anterior
            Tail = Tail.Previous;
            //configura como ultimo.
            Tail.Next = null;
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
                var founded = SearchFirstOne(target.Value);
                var prev = founded.Previous;

                prev.Next = newNode;
                newNode.Previous = prev;

                founded.Previous = newNode;
                newNode.Next = founded;
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
                var founded = SearchFirstOne(target.Value);
                var next = founded.Next;

                newNode.Next = next;
                next.Previous = newNode;

                newNode.Previous = founded;
                founded.Next = newNode;
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
                current = current.Next;
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
                current = current.Previous;
            }
            Console.ReadKey();
        }

        public override string ToString()
           => $"valor: {Head.Value}";

    }
}
