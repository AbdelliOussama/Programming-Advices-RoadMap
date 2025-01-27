using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePractise
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinarySearchTree<T> where T:IComparable
    {
        public TreeNode<T> Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }
        public void Insert(T Value)
        {
            Root = Insert(Root, Value);
        }
        private TreeNode<T> Insert(TreeNode<T> Node, T value)
        {
            if (Node == null)
                return new TreeNode<T>(value);
            if (value.CompareTo(Node.Value) < 0)
            {
                Node.Left = Insert(Node.Left, value);
            }
            else
            {
                Node.Right = Insert(Node.Right, value);
            }
            return Node;
        }
        public bool Search(T value)
        {
            return Search(Root, value)!=null;
        }
        private TreeNode<T> Search(TreeNode<T> Node, T value)
        {
            if(Node==null && Node.Value.Equals(value))
            {
                return Node;
            }
            if (value.CompareTo(Node.Value) < 0)
            {
                return Search(Node.Left, value);
            }
            else
            {
                return Search(Node.Right, value);
            }
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }
        private void PreOrder(TreeNode<T>Node)
        {
            if(Node!=null)
            {
                Console.Write(Node.Value+" ");
                PreOrder(Node.Left);
                PreOrder(Node.Right);
            }
        }
        public void PostOrder()
        {
            PostOrder(Root);
        }
        private void PostOrder(TreeNode<T> Node)
        {
            if (Node != null)
            {
                PostOrder(Node.Left);
                PostOrder(Node.Right);
                Console.Write(Node.Value + " ");
            }
        }
        public void InOrder()
        {
            InOrder(Root);
        }
        private void InOrder(TreeNode<T> Node)
        {
            if (Node != null)
            {
                InOrder(Node.Left);
                Console.Write(Node.Value + " ");
                InOrder(Node.Right);
            }
        }

        public void LevelOrder()
        {
            LevelOrder(Root);
        }
        private void LevelOrder(TreeNode<T> Node)
        {

            if (Node != null)
            {
                Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
                queue.Enqueue(Node);
                while (queue.Count > 0)
                {
                    TreeNode<T> CurrentNode = queue.Dequeue();
                    Console.Write(CurrentNode.Value + " ");
                    if (CurrentNode.Left != null)
                        queue.Enqueue(CurrentNode.Left);
                    if (CurrentNode.Right != null)
                        queue.Enqueue(CurrentNode.Right);
                }
            }
        }
        public void GraphicalPrint()
        {
            GraphicalPrint(Root, 0);
        }
        private void GraphicalPrint(TreeNode<T> Node, int space)
        {
            if (Node == null)
                return;
            space += 10;
            GraphicalPrint(Node.Right, space);
            Console.WriteLine();
            for (int i = 10; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Node.Value);
            GraphicalPrint(Node.Left, space);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(18);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(8);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(13);
            binarySearchTree.Insert(17);
            binarySearchTree.Insert(19);
            

            Console.WriteLine("PreOrder Traversal");
            binarySearchTree.PreOrder();
            Console.WriteLine();
            Console.WriteLine("PostOrder Traversal");
            binarySearchTree.PostOrder();
            Console.WriteLine();
            Console.WriteLine("InOrder Traversal");
            binarySearchTree.InOrder();
            Console.WriteLine();
            Console.WriteLine("LevelOrder Traversal");
            binarySearchTree.LevelOrder();
            Console.WriteLine();
            Console.WriteLine("Graphical Print");
            binarySearchTree.GraphicalPrint();
            Console.WriteLine();


        }
    }
}
