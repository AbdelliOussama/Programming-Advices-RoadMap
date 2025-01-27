using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Society_Hierarchy_Task_FromChatGpt
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }

        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        public void LevelOrderTraversal()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Value);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<string>();
            binaryTree.Insert("CEO");
            binaryTree.Insert("Head of Department 1");
            binaryTree.Insert("Head of Department 2");
            binaryTree.Insert("Team Lead 1");
            binaryTree.Insert("Team Lead 2");
            binaryTree.Insert("Team Member 1");
            binaryTree.Insert("Team Member 2");

            Console.WriteLine("Level Order Traversal of Organizational Hierarchy:");
            binaryTree.LevelOrderTraversal();


            Console.ReadKey();
        }
    }
}
