namespace BinaryTree
{
    public class Node
    {
        public int? Data { get; set; }

        public Node Right { get; set; }

        public Node Left { get; set; }

        public Node()
        {
            Data = null;
            Right = null;
            Left = null;
        }

        public Node(int? data)
        {
            Data = data;
            Right = null;
            Left = null;
        }
    }
}
