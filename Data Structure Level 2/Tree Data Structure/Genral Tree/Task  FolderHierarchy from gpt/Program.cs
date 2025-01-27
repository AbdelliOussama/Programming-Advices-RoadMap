
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Task__FolderHierarchy_from_gpt
{
    /*
    Use Case: File System Structure
    Problem Statement:
    Design and implement a General Tree that mimics a file system structure where:

    Each node represents either a folder or a file.
    Folders can have multiple child nodes(files or subfolders).
    Files are leaf nodes with no children.
    Requirements:

    Add Folders and Files: Create methods to add folders and files to the tree under a specified parent.
    Search by Name: Implement a Find method to search for a folder or file by its name.
    Print Hierarchy: Write a method to display the folder and file structure in a tree-like format.
    Additional Features:
    Count total files and folders.
    Retrieve all files with a specific extension (e.g., .txt, .pdf).
    Delete a folder and all its contents.

    Implementation Outline
    Node Class:
    Name: Stores the name of the folder or file.
    IsFolder: A boolean to indicate whether the node is a folder or a file.
    Children: A list to hold child nodes for folders.
    Tree Class:

    Root: Represents the root folder.
    Methods:
    AddFolder(string parentName, string folderName): Adds a folder under a specified parent.
    AddFile(string parentName, string fileName): Adds a file under a specified parent.
    Find(string name): Searches for a node by name.
    PrintTree(): Prints the folder and file structure.
    CountFiles(): Returns the total number of files.
    CountFolders(): Returns the total number of folders.
    DeleteNode(string name): Deletes a folder or file by name.
    */


    public class Node
    {
        public string Name { get; set; }
        public bool IsFolder { get; set; }
        public List<Node> Children { get; set; }

        public Node(string name, bool isFolder = true)
        {
            Name = name;
            IsFolder = isFolder;
            Children = new List<Node>();
        }

        public void AddChild(Node node)
        {
            Children.Add(node);
        }

        public void DeleteChild(Node node)
        {
            Children.Remove(node);
        }

        public Node Find(string name)
        {
            if (this.Name == name)
                return this;

            foreach (Node child in Children)
            {
                Node result = child.Find(name);
                if (result != null)
                    return result;
            }

            return null;
        }
    }

    public class Tree
    {
        public Node Root { get; set; }

        public Tree(string name)
        {
            Root = new Node(name);
        }

        public void AddFolder(string parentName, string folderName)
        {
            Node parentNode = Root.Find(parentName);
            if (parentNode != null)
            {
                parentNode.AddChild(new Node(folderName));
            }
            else
            {
                Console.WriteLine($"Parent folder '{parentName}' not found.");
            }
        }

        public void AddFile(string parentName, string fileName)
        {
            Node parentNode = Root.Find(parentName);
            if (parentNode != null)
            {
                parentNode.AddChild(new Node(fileName, false));
            }
            else
            {
                Console.WriteLine($"Parent folder '{parentName}' not found.");
            }
        }

        public void PrintTree(string indent = "")
        {
            _PrintTree(Root, indent);
        }

        private void _PrintTree(Node node, string indent)
        {
            Console.WriteLine(indent + (node.IsFolder ? "[Folder] " : "[File] ") + node.Name);
            foreach (Node child in node.Children)
            {
                _PrintTree(child, indent + "  ");
            }
        }

        public int CountFiles(Node node)
        {
            if (node == null)
                return 0;

            int fileCount = 0;
            if (!node.IsFolder)
                fileCount++;

            foreach (Node child in node.Children)
            {
                fileCount += CountFiles(child);
            }

            return fileCount;
        }

        public int CountFolders(Node node)
        {
            if (node == null)
                return 0;

            int folderCount = 0;
            if (node.IsFolder)
                folderCount++;

            foreach (Node child in node.Children)
            {
                folderCount += CountFolders(child);
            }

            return folderCount;
        }

        public void DeleteNode(string nodeName)
        {
            if (Root.Name == nodeName)
            {
                Console.WriteLine("Cannot delete the root node.");
                return;
            }

            DeleteNode(Root, nodeName);
        }

        private bool DeleteNode(Node parent, string nodeName)
        {
            foreach (var child in parent.Children)
            {
                if (child.Name == nodeName)
                {
                    parent.DeleteChild(child);
                    return true;
                }
            }
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree("Root");
            tree.AddFolder("Root", "Documents");
            tree.AddFolder("Root", "Music");
            tree.AddFile("Documents", "Resume.pdf");
            tree.AddFile("Documents", "CoverLetter.docx");
            tree.AddFolder("Music", "Rock");
            tree.AddFile("Rock", "Song1.mp3");

            Console.WriteLine("Tree Structure:");
            tree.PrintTree();

            Console.WriteLine($"\nTotal Files: {tree.CountFiles(tree.Root)}");
            Console.WriteLine($"Total Folders: {tree.CountFolders(tree.Root)}");

            Console.WriteLine("\nDeleting 'Music'...");
            tree.DeleteNode("Music");

            Console.WriteLine("\nTree Structure After Deletion:");
            tree.PrintTree();

            Console.ReadKey();
        }
    }
}
