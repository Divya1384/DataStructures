using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void AddNode(Node node)
        {
            if (Head == null)
            {
                Head = node;
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.Next = node;
        }

        public void DeleteNode(int value)
        {
            Node temp = Head;
            Node prev = null;
            if (Head.Data == value)
            {
                Head = temp.Next;
                return;
            }
            while (temp != null & temp.Data != value)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null) return;

            prev.Next = temp.Next;
        }

        public void InsertAtFirst(int value)
        {
            var newNode = new Node(value)
            {
                Next = Head
            };
            Head = newNode;
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
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Using iteration
        /// </summary>
        public void ReverseList()
        {
            Node prev = null;
            Node next = null;
            Node current = Head;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        /// <summary>
        /// Using recursion
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node Reverse(Node node)
        {
            if (node == null || node.Next == null)
            {
                return node;
            }
            Node reverse = Reverse(node.Next);
            node.Next.Next = node;
            node.Next = null;
            Head = reverse;
            return reverse;
        }

        /// <summary>
        /// Floyd Cycle Detection algorithm
        /// </summary>
        /// <param name="loop"></param>
        /// <param name="node"></param>
        public int DetectAndRemoveLoop(Node node)
        {
            Node slow = node;
            Node fast = node;

            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                // If slow and fast meet at same
                // point then loop is present
                if (slow == fast)
                {
                    RemoveLoop(slow, node);
                    return 1;
                }
            }

            return 0;
        }

        /// <summary>
        /// Removing the loop by counting the number of nodes in the loop
        /// </summary>
        /// <param name="loop"></param>
        /// <param name="node"></param>
        public void RemoveLoop(Node loop, Node node)
        {
            Node ptr1 = loop;
            Node ptr2 = loop;

            int k = 1; 
            
            //Find the number of nodes in the loop
            while (ptr1.Next != ptr2)
            {
                ptr1 = ptr1.Next;
                k++;
            }

            //Fix one pinter to head
            ptr1 = node;

            //Fix the other pointer to k nodes after head
            ptr2 = node;
            for (int i=0; i < k; i++)
            {
                ptr2 = ptr2.Next;
            }

            //Move both pointers at the same pace and they will meet at some point
            while (ptr2 != ptr1)
            {
                ptr1 = ptr1.Next;
                ptr2 = ptr2.Next;
            }

            while (ptr2.Next != ptr1)
            {
                ptr2 = ptr2.Next;
            }

            ptr2.Next = null;
        }

        /// <summary>
        /// Detecting and removing the loop without counting the nodes in the loop
        /// </summary>
        /// <param name="node"></param>
        public void DetectAndRemoveLoops(Node node)
        {
            if (node == null || node.Next == null)
            {
                return;
            }

            Node slow = node;
            Node fast = node;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast) break;
            }

            if (slow == fast)
            {
                slow = node;
                while (slow.Next != fast.Next)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
                fast.Next = null;
            }
        }

        public void HashAndRemove(Node node)
        {
            HashSet<Node> hashSet = new HashSet<Node>();
            Node prev = null;
            while (node != null)
            {
                if (hashSet.Contains(node))
                {
                    prev.Next = null;
                    return;
                }
                hashSet.Add(node);
                prev = node;
                node = node.Next;
            }
        }

        public void PrintMiddle(Node node)
        {
            if (node == null || node.Next == null)
            {
                Console.WriteLine(node.Data);
                return;
            }

            Node slow = node;
            Node fast = node;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            Console.WriteLine("Middle value : " + slow.Data);
        }
    }
}
