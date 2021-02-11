namespace AdvancedAlgorithms.DataStructure.LinkedList
{
    public class Node<T> where T : struct
    {
        private T Value;
        private Node<T> Next;

        public Node(T item, Node<T> next)
        {
            this.Value = item;
            this.Next = next;
        }

        public Node<T> GetNext()
        {
            return Next;
        }

        public T GetValue()
        {
            return Value;
        }

        public void SetValue(T value)
        {
            this.Value = value;
        }

        public Node<T> SetNext(Node<T> node)
        {
            Next = node;
            return this;
        }

        public override string ToString()
        {
            return "LinkedListNode{" + "value=" + Value + '}';
        }
    }
}