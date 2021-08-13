using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();

            doublyLinkedList.AddNode(new Node(10));
            doublyLinkedList.AddNode(new Node(20));
            doublyLinkedList.AddNode(new Node(30));
            doublyLinkedList.AddNode(new Node(40));
            doublyLinkedList.AddNode(new Node(50));
            doublyLinkedList.AddNode(new Node(60));

            doublyLinkedList.Print();

            doublyLinkedList.RemoveNode(10);
            doublyLinkedList.Print();

            doublyLinkedList.RemoveNode(40);
            doublyLinkedList.Print();

            doublyLinkedList.RemoveNode(60);
            doublyLinkedList.Print();

            doublyLinkedList.AddNode(new Node(40));
            doublyLinkedList.Print();

            //Remove loop
            var list = new DoublyLinkedList();
            list.Head = new Node(50);
            list.Head.Next = new Node(20);list.Head.Next.Prev = list.Head;
            list.Head.Next.Next = new Node(15); list.Head.Next.Next.Prev = list.Head.Next;
            list.Head.Next.Next.Next = new Node(4); list.Head.Next.Next.Next.Prev = list.Head.Next.Next;
            list.Head.Next.Next.Next.Next = new Node(10); list.Head.Next.Next.Next.Next.Prev = list.Head.Next.Next.Next;

            // Creating a loop for testing
            list.Head.Next.Next.Next.Next.Next = list.Head.Next.Next;

            list.DetectAndRemoveLoop(list.Head);

            Console.WriteLine("After removing the loop");

            list.Print();

            Console.Read();
        }
    }
}
