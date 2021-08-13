using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public Node root { get; set; }

        public BinarySearchTree()
        {
            root = null;    
        }

        public Node Insert(Node node, int? data)
        {
            Node newNode = new Node(data);

            if (node == null)
            {
                node = newNode;
                return node;
            }

            if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }

            if (data > node.Data)
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }

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

        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        public Node GetMinimumKey(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public void Delete(int? data)
        {

        }
    }
}
