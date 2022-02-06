namespace CircularLinkedlist
{
    public class CircularLinkedList
    {
        public Node Head { get; set; }

        public CircularLinkedList()
        {
            Head = null;
        }

        public void Insert(Node node)
        {
            if (Head == null)
            {
                node.Next = node;
                Head = node;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }

        }

        public void Delete()
        {

        }

        public void Print()
        {

        }
    }
}
