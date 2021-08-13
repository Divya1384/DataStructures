using System;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }

        public void AddNode(Node node)
        {
            if (Head == null)
            {
                Head = node;
                return;
            }
            Node temp = GetLastNode();
            node.Prev = temp;
            temp.Next = node;
        }

        public void InsertAtFirst(int value)
        {
            Node newNode = new Node(value)
            {
                Next = Head
            };
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            Head = newNode;
        }

        public void RemoveNode(int value)
        {
            Node temp = Head;

            if (temp.Data == value)
            {
                Head = temp.Next;
                Head.Prev = null;
                return;
            }

            while (temp != null && temp.Data != value)
            {
                temp = temp.Next;
            }

            if (temp == null) return;

            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }

            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
        }

        public Node GetLastNode()
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public void Print()
        {
            Node node = Head;
            while (node != null)
            {
                string prevNode = (node.Prev == null) ? "None" : node.Prev.Data.ToString();
                string nextNode = (node.Next == null) ? "None" : node.Next.Data.ToString();
                Console.WriteLine($"Current Node Value - {node.Data} Previous Node Value - {prevNode} Next Node Value - {nextNode}");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public void DetectAndRemoveLoop(Node node)
        {
            Node prev = null;

            while (node != null)
            {
                if (node.Prev != prev)
                {
                    prev.Next = null;
                    return;
                }

                prev = node;
                node = node.Next;
            }
        }
    }
}
