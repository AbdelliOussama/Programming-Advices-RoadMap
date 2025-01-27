using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Traversal_Practise
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
        public Tree()
        {
            Root = null;
        }
        public void Insert(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>(data);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                TreeNode<T> temp = queue.Dequeue();
                if (temp.Left == null)
                {
                    temp.Left = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(temp.Left);
                }
                if (temp.Right == null)
                {
                    temp.Right = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(temp.Right);
                }
            }
        }
        public void PreOrder()
        {
            PreOrder(Root);
        }
        private void PreOrder(TreeNode<T> root)
        {
            if (root == null)
                return;
            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
        public void InOrder()
        {
            InOrder(Root);
        }
        private void InOrder(TreeNode<T> root)
        {
            if (root == null)
                return;
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
        public void PostOrder()
        {
            PostOrder(Root);
        }
        private void PostOrder(TreeNode<T> root)
        {
            if (root == null)
                return;
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }
        public void LevelOrder()
        {
            if (Root == null)
                return;
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                TreeNode<T> temp = queue.Dequeue();
                Console.Write(temp.Data + " ");
                if (temp.Left != null)
                    queue.Enqueue(temp.Left);
                if (temp.Right != null)
                    queue.Enqueue(temp.Right);
            }
        }
        public int Height()
        {
            return Height(Root);
        }
        private int Height(TreeNode<T> Node)
        {
            if (Node == null)
                return 0;
            int leftHeight = Height(Node.Left);
            int rightHeight = Height(Node.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public bool IsLeaf()
        {
            return IsLeaf(Root);
        }
        private bool IsLeaf(TreeNode<T> Node)
        {
            if (Node == null)
                return false;
            return Node.Left == null && Node.Right == null;
        }
        public int NumberOfLeaves()
        {
            return NumberOfLeaves(Root);
        }
        private int NumberOfLeaves(TreeNode<T> Node)
        {
            if (Node == null)
                return 0;
            if (IsLeaf(Node))
                return 1;
            return NumberOfLeaves(Node.Left) + NumberOfLeaves(Node.Right);
        }
        public int NumberOfNodes()
        {
            return NumberOfNodes(Root);
        }
        private int NumberOfNodes(TreeNode<T> Node)
        {
            if (Node == null)
                return 0;
            if (IsLeaf(Node))
                return 1;
            return NumberOfNodes(Node.Left) + NumberOfNodes(Node.Right) + 1;
        }

        public bool IsBalanced()
        {
            return IsBalanced(Root);
        }
        private bool IsBalanced(TreeNode<T> Node)
        {
            if (Node == null)
                return true;
            if (IsLeaf(Node))
                return true;
            return IsBalanced(Node.Left) && IsBalanced(Node.Right) && Math.Abs(Height(Node.Left) - Height(Node.Right)) <= 1;

        }

        public void ConvertToMirror()
        {
            ConvertToMirror(Root);
        }
        private void ConvertToMirror(TreeNode<T> Node)
        {
            if (Node == null)
                return;
            ConvertToMirror(Node.Left);
            ConvertToMirror(Node.Right);
            TreeNode<T> temp = Node.Left;
            Node.Left = Node.Right;
            Node.Right = temp;
        }

        public void ZigZagTraversal()
        {
            ZigZagTraversal(Root);
        }
        private void ZigZagTraversal(TreeNode<T> Node)
        {
            if (Node == null)
                return;
            Stack<TreeNode<T>> currentLevel = new Stack<TreeNode<T>>();
            Stack<TreeNode<T>> nextLevel = new Stack<TreeNode<T>>();
            currentLevel.Push(Node);
            bool leftToRight = true;
            while (currentLevel.Count > 0)
            {
                TreeNode<T> temp = currentLevel.Pop();
                if (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    if (leftToRight)
                    {
                        if (temp.Left != null)
                            nextLevel.Push(temp.Left);
                        if (temp.Right != null)
                            nextLevel.Push(temp.Right);
                    }
                    else
                    {
                        if (temp.Right != null)
                            nextLevel.Push(temp.Right);
                        if (temp.Left != null)
                            nextLevel.Push(temp.Left);
                    }
                }
                if (currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<TreeNode<T>> tempStack = currentLevel;
                    currentLevel = nextLevel;
                    nextLevel = tempStack;
                }
            }
        }
        public void GraphicalRepresentation()
        {
            GraphicalRepresentation(Root, 0);
        }
        private void GraphicalRepresentation(TreeNode<T> Node, int space)
        {
            if (Node == null)
                return;
            space += 10;
            GraphicalRepresentation(Node.Right, space);
            Console.WriteLine();
            for (int i = 10; i < space; i++)
                Console.Write(" ");
            Console.Write(Node.Data + "\n");
            GraphicalRepresentation(Node.Left, space);

        }
    }

    public  class Program
    {

        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>();
            tree.Insert("A");
            tree.Insert("B");
            tree.Insert("C");
            tree.Insert("D");
            tree.Insert("E");
            tree.Insert("F");

            tree.PreOrder();
            Console.WriteLine();
            tree.InOrder();
            Console.WriteLine();
            tree.PostOrder();
            Console.WriteLine();
            tree.LevelOrder();
            Console.WriteLine();

            int height = tree.Height();
            Console.WriteLine("Height of the tree is: " + height);

            bool isLeaf = tree.IsLeaf();
            Console.WriteLine("Is Leaf ?: " + isLeaf);

            int numberOfLeaves = tree.NumberOfLeaves();
            Console.WriteLine("Number of Leaves: " + numberOfLeaves);

            int numberOfFullNodes = tree.NumberOfNodes();
            Console.WriteLine("Number of Nodes: " + numberOfFullNodes);
            tree.GraphicalRepresentation();
            Console.WriteLine();

            bool isBalanced = tree.IsBalanced();

            tree.ConvertToMirror();

            tree.GraphicalRepresentation();
            Console.WriteLine();
            tree.LevelOrder();
            Console.WriteLine();

            tree.ZigZagTraversal();
            Console.WriteLine();

            Console.WriteLine("Is Balanced ?: " + isBalanced);


            Console.ReadKey();


        }
    }
}
