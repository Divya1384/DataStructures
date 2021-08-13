using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary tree
            Console.WriteLine("---------------------------------Binary Tree--------------------------------------");
            var binaryTree = new BinaryTreeByLinkedList();
            binaryTree.Insert(10);
            binaryTree.Insert(30);
            binaryTree.Insert(20);
            binaryTree.Insert(50);
            binaryTree.Insert(40);

            Console.WriteLine("PreOrder");
            binaryTree.PreOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("PreOrder - Stack");
            binaryTree.PreOrder();
            Console.WriteLine();

            Console.WriteLine("InOrder");
            binaryTree.InOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("InOrder - Stack");
            binaryTree.InOrder();
            Console.WriteLine();

            Console.WriteLine("PostOrder");
            binaryTree.PostOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("PostOrder - Stack");
            binaryTree.PostOrder();
            Console.WriteLine();

            binaryTree.Delete(30);

            Console.WriteLine("PreOrder");
            binaryTree.PreOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("InOrder");
            binaryTree.InOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("PostOrder");
            binaryTree.PostOrder(binaryTree.root);
            Console.WriteLine();

            Console.WriteLine("---------------------------------Binary Search Tree--------------------------------------");
            var binarySearchTree = new BinarySearchTree();
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 20);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 30);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 10);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 15);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 50);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 40);
            binarySearchTree.root = binarySearchTree.Insert(binarySearchTree.root, 60);

            Console.WriteLine("PreOrder");
            binarySearchTree.PreOrder(binarySearchTree.root);
            Console.WriteLine();

            Console.WriteLine("InOrder");
            binarySearchTree.InOrder(binarySearchTree.root);
            Console.WriteLine();

            Console.WriteLine("PostOrder");
            binarySearchTree.PostOrder(binarySearchTree.root);
            Console.WriteLine();

            Console.Read();
        }
    }
}
