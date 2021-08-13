using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.AddNode(new Node(10));

            linkedList.AddNode(new Node(20));

            linkedList.AddNode(new Node(30));

            linkedList.AddNode(new Node(40));

            linkedList.AddNode(new Node(50));

            linkedList.AddNode(new Node(60));

            linkedList.Print();

            linkedList.Reverse(linkedList.Head);

            linkedList.Print();

            linkedList.ReverseList();

            linkedList.Print();

            linkedList.DeleteNode(60);

            linkedList.Print();

            linkedList.DeleteNode(30);

            linkedList.Print();

            linkedList.DeleteNode(10);

            linkedList.Print();

            //Remove loop
            LinkedList list = new LinkedList();
            list.Head = new Node(50);
            list.Head.Next = new Node(20);
            list.Head.Next.Next = new Node(15);
            list.Head.Next.Next.Next = new Node(4);
            list.Head.Next.Next.Next.Next = new Node(10);

            // Creating a loop for testing
            list.Head.Next.Next.Next.Next.Next = list.Head.Next.Next;

            list.HashAndRemove(list.Head);

            Console.WriteLine("Linked List after removing loop : ");
            list.Print();

            list.PrintMiddle(list.Head);

            Console.Read();
        }
    }
}
