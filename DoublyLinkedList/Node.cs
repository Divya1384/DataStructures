namespace DoublyLinkedList
{
    public class Node
    {
        public int Data { get; set; }

        public Node Prev { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Data = value;
            Next = null;
            Prev = null;
        }
    }
}
