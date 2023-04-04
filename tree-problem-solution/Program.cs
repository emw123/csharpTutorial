using System;
    public class GFG
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }
        public static void Main(string[] args)
        {

            Node root = new Node(5);
            root.left = new Node(10);
            root.left.left = new Node(8);
            root.left.right = new Node(12);
            root.right = new Node(3);
            root.right.right = new Node(1);
        }
    }