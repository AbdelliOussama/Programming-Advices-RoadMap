using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTree_Example2
{
    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string name, string LastName)
        {
            this.Name = name;
            this.LastName = LastName;
        }
        public override string ToString()
        {
            return this.Name+" "+this.LastName;
        }

        public bool Equals(Person other)
        {
            return (this.Name ==  other.Name) && (this.LastName == other.LastName);
        }
    }

    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; private set; }

        public TreeNode(T value)
        {
            this.Value = value;
            Children = new List<TreeNode<T>>();
        }
        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
        public TreeNode<T> Find(TreeNode<T> Child)
        {
            if(EqualityComparer<T>.Default.Equals(this.Value ,Child.Value))
                return this;

            foreach(TreeNode<T> child in this.Children)
            {
                TreeNode<T> Result = child.Find(Child);

                if(Result != null)
                    return Result;
            }
            return null;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
        public Tree(T Value)
        {
            Root = new TreeNode<T>(Value);
        }

        public void PrintTree(string Indent)
        {
            PrintTree(this.Root, Indent);
        }
        private void PrintTree(TreeNode<T> Root, string Indent)
        {
            Console.WriteLine(Indent + Root.Value.ToString());

            foreach (TreeNode<T> Child in Root.Children)
            {
                PrintTree(Child, Indent + "-->");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Tree<Person> GrandFather = new Tree<Person>(new Person("kmiti", "Abdelli"));
            TreeNode<Person> Oncle1 = new TreeNode<Person>(new Person("Wajdi", "Abdelli"));
            TreeNode<Person> Oncle2 = new TreeNode<Person>(new Person("Tijani", "Abdelli"));
            TreeNode<Person> Oncle3 = new TreeNode<Person>(new Person("AAdel", "Abdelli"));
            TreeNode<Person> Baba = new TreeNode<Person>(new Person("Mohamed", "Abdelli"));
            TreeNode<Person> Tante1 = new TreeNode<Person>(new Person("Hayet", "Abdelli"));



            TreeNode<Person> Amen = new TreeNode<Person>(new Person("Amen", "Abdelli"));
            TreeNode<Person> Adem = new TreeNode<Person>(new Person("Adem", "Abdelli"));
            TreeNode<Person> Iyed = new TreeNode<Person>(new Person("Amen", "Abdelli"));

            TreeNode<Person> Hajer= new TreeNode<Person>(new Person("Hajer", "Aoueni"));
            TreeNode<Person> Ghofrane = new TreeNode<Person>(new Person("Ghofrane", "Jaouedi"));

            TreeNode<Person> Imen = new TreeNode<Person>(new Person("Imen", "Abdelli"));
            TreeNode<Person> Omar = new TreeNode<Person>(new Person("Omar", "Aoueni"));






            GrandFather.Root.AddChild(Oncle1);
            GrandFather.Root.AddChild(Oncle2);
            GrandFather.Root.AddChild(Baba);
            GrandFather.Root.AddChild(Oncle3);
            GrandFather.Root.AddChild(Tante1);

            Tante1.AddChild(Hajer);
            Tante1.AddChild(Imen);
            Hajer.AddChild(Ghofrane);
            Imen.AddChild(Omar);

            GrandFather.PrintTree(" ");

            if (Hajer.Find(Omar) != null)
                Console.WriteLine("found");
            else
                Console.WriteLine("Not Found");



            Console.ReadKey();




        }
    }
}
