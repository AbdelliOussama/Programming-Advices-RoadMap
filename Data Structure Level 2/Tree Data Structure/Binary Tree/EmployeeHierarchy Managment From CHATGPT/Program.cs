using System;
using System.Collections.Generic;

namespace EmployeeHierarchy_Managment
{
    public class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string name, int employeeID)
        {
            Name = name;
            EmployeeID = employeeID;
        }

        public override string ToString()
        {
            return $"ID: {EmployeeID}, Name: {Name}";
        }
    }

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

    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public void Add(T value)
        {
            TreeNode<T> node = new TreeNode<T>(value);
            if (Root == null)
            {
                Root = node;
                return;
            }

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();

                if (currentNode.Left == null)
                {
                    currentNode.Left = node;
                    return;
                }
                else
                    queue.Enqueue(currentNode.Left);

                if (currentNode.Right == null)
                {
                    currentNode.Right = node;
                    return;
                }
                else
                    queue.Enqueue(currentNode.Right);
            }
        }

        public void PrintTree()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Value.ToString());

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
        }

        public TreeNode<T> Find(T value)
        {
            if (Root == null) return null;

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();

                if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
                {
                    return currentNode;
                }

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return null;
        }

        public int CountEmployee()
        {
            if (Root == null) return 0;

            int count = 0;
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                count++;

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<Employee> employeeTree = new Tree<Employee>();

            employeeTree.Add(new Employee("Alice", 1));
            employeeTree.Add(new Employee("Bob", 2));
            employeeTree.Add(new Employee("Charlie", 3));
            employeeTree.Add(new Employee("David", 4));
            employeeTree.Add(new Employee("Eve", 5));

            Console.WriteLine("Employee Hierarchy:");
            employeeTree.PrintTree();

            Console.WriteLine($"\nTotal Employees: {employeeTree.CountEmployee()}");

            Employee searchResult = employeeTree.Find(new Employee("Charlie", 3))?.Value as Employee;
            Console.WriteLine($"\nFound Employee: {searchResult}");

            Console.ReadKey();
        }
    }
}
