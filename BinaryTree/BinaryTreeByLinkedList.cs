using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTreeByLinkedList
    {
        public Node root { get; set; }

        public BinaryTreeByLinkedList()
        {
            root = null;
        }

        public void Insert(int? data)
        {
            Node newNode = new Node(data);
            Node current = null;

            if (root == null)
            {
                root = newNode;
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                current = queue.Peek();
                queue.Dequeue();

                if (current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                queue.Enqueue(current.Left);

                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                queue.Enqueue(current.Right);
            }
        }

        /// <summary>
        /// Depth First Traversal - Inorder
        /// Left Root Right
        /// </summary>
        /// <param name="node"></param>
        public void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        /// <summary>
        /// Depth First Traversal - Preorder
        /// Root Left Right
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        /// <summary>
        /// Depth First Traversal - Postorder
        /// Left Right Root
        /// </summary>
        /// <param name="node"></param>
        public void PostOrder (Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        public void Delete(int? data)
        {
            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null)
            {
                if (root.Data == data)
                {
                    root = null;
                }
                return;
            }

            Node temp = null;
            Node keyNode = null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                temp = queue.Peek();
                queue.Dequeue();
                              
                if (temp.Data == data)
                {
                    keyNode = temp;
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }
            }

            if (keyNode != null)
            {
                var x = temp.Data;
                DeleteDeepest(temp);
                keyNode.Data = x;
            }
        }

        private void DeleteDeepest(Node delNode)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node temp = null;

            while (queue.Count > 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if (temp == delNode)
                {
                    temp = null;
                    return;
                }

                if (temp.Right != null)
                {
                    if (temp.Right == delNode)
                    {
                        temp.Right = null;
                        return;
                    }
                    queue.Enqueue(temp.Right);
                }

                if (temp.Left != null)
                {
                    if (temp.Left == delNode)
                    {
                        temp.Left = null;
                        return;
                    }
                    queue.Enqueue(temp.Left);
                }
            }
        }

        public void PreOrder()
        {
            if (root == null)
            {
                return;
            }

            Node temp = root;
            Stack<Node> nodeStack = new Stack<Node>();
            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                temp = nodeStack.Peek();
                nodeStack.Pop();

                Console.Write(temp.Data + " ");

                if (temp.Right != null)
                {
                    nodeStack.Push(temp.Right);
                }
                if (temp.Left != null)
                {
                    nodeStack.Push(temp.Left);
                }
            }
        }

        public void InOrder()
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> nodeStack = new Stack<Node>();

            Node temp = root;

            while (temp != null || nodeStack.Count > 0)
            {
                /* Reach the left most Node of the curr Node */
                while (temp != null)
                {
                    nodeStack.Push(temp);
                    temp = temp.Left;
                }

                /* Current must be NULL at this point */
                temp = nodeStack.Pop();

                Console.Write(temp.Data + " ");

                /* we have visited the node and its left subtree.  Now, it's right subtree's turn */
                temp = temp.Right;
            }
        }

        public void PostOrder()
        {
            var list = new List<int?>();

            if (root == null)
            {
                return;
            }

            Stack<Node> nodeStack = new Stack<Node>();
            nodeStack.Push(root);

            Node prev = null;

            while (nodeStack.Count > 0)
            {
                Node current = nodeStack.Peek();
                if (prev == null || prev.Left == current || prev.Right == current)
                {
                    if (current.Left != null)
                    {
                        nodeStack.Push(current.Left);
                    }
                    else if (current.Right != null)
                    {
                        nodeStack.Push(current.Right);
                    }
                    else
                    {
                        nodeStack.Pop();
                        list.Add(current.Data);
                    }
                }
                else if (current.Left == prev)
                {
                    if (current.Right != null)
                    {
                        nodeStack.Push(current.Right);
                    }
                    else
                    {
                        nodeStack.Pop();
                        list.Add(current.Data);
                    }
                }
                else if (current.Right == prev)
                {
                    nodeStack.Pop();
                    list.Add(current.Data);
                }
                prev = current;
            }
            foreach(var data in list)
            {
                Console.Write(data + " ");
            }
        }
    }
}
