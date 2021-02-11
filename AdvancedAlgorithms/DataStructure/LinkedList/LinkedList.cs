namespace AdvancedAlgorithms.DataStructure.LinkedList
{
    public class LinkedList<T> where T : struct
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        // DONE:
        public void AddFirst(T item)
        {
            head = new Node<T>(item, head);

        }

        public void Add(Node<T> node, T item)
        {
            //antigo
            var oldNext = node.GetNext() ?? null;

            //seta o novo
            node.SetNext(new Node<T>(item, oldNext));
        }

        public void Remove()
        {
            head = head.GetNext() ?? null;
        }

        //public Node<T> Search(T value)
        //{

        //}
    }
}