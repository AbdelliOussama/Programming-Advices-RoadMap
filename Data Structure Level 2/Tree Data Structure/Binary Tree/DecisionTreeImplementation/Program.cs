using System;
using System.Collections.Generic;

namespace DecisionTreeImplementation
{
    public class TreeNode
    {
        public string QuestionOrResult { get; set; } // Holds a question or result
        public Dictionary<string, TreeNode> Children { get; set; } // Stores child nodes with options as keys

        public TreeNode(string questionOrResult)
        {
            QuestionOrResult = questionOrResult;
            Children = new Dictionary<string, TreeNode>();
        }

        // Add a child node for a specific answer
        public void AddChild(string answer, TreeNode childNode)
        {
            Children[answer] = childNode;
        }
    }

    public class DecisionTree
    {
        public TreeNode Root { get; private set; }

        public DecisionTree(string rootQuestion)
        {
            Root = new TreeNode(rootQuestion);
        }

        // Method to interactively traverse the tree
        public void TraverseTree()
        {
            TreeNode currentNode = Root;

            while (currentNode.Children.Count > 0)
            {
                Console.WriteLine(currentNode.QuestionOrResult); // Print the question
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (currentNode.Children.ContainsKey(userAnswer))
                {
                    currentNode = currentNode.Children[userAnswer]; // Move to the next node based on the answer
                }
                else
                {
                    Console.WriteLine("Invalid answer. Try again.");
                }
            }

            Console.WriteLine($"Result: {currentNode.QuestionOrResult}"); // Print the result
        }

        // Method to print the entire tree structure
        public void PrintTree()
        {
            PrintTree(Root, "");
        }

        private void PrintTree(TreeNode node, string indent)
        {
            Console.WriteLine(indent + node.QuestionOrResult);
            foreach (var child in node.Children)
            {
                Console.WriteLine(indent + $" -> {child.Key}");
                PrintTree(child.Value, indent + "    ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the decision tree
            DecisionTree decisionTree = new DecisionTree("Are you experienced in programming?");

            // Add nodes
            var yesNode = new TreeNode("Do you know OOP concepts?");
            var noNode = new TreeNode("Start with basic programming tutorials.");
            decisionTree.Root.AddChild("Yes", yesNode);
            decisionTree.Root.AddChild("No", noNode);

            var oopYesNode = new TreeNode("You are an intermediate programmer.");
            var oopNoNode = new TreeNode("Learn OOP to advance.");
            yesNode.AddChild("Yes", oopYesNode);
            yesNode.AddChild("No", oopNoNode);

            // Print the tree structure
            Console.WriteLine("Decision Tree Structure:");
            decisionTree.PrintTree();

            Console.WriteLine("\n--- Interactive Traversal ---");
            // Traverse the tree interactively
            decisionTree.TraverseTree();

            Console.ReadKey();
        }
    }
}
