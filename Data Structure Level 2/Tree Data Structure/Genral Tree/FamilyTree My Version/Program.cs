using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree_My_Version
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            Children = new List<TreeNode<T>>();
        }
        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public TreeNode<T>Find(T Value)
        {
            if (EqualityComparer<T>.Default.Equals(this.Value, Value))
            {
                return this;
            }
            foreach (TreeNode<T> child in Children)
            {
                var Found = child.Find(Value);
                if(Found != null)
                    return Found ;   
               
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
       
        public TreeNode<T> Find(T Value)
        {
            return Root.Find(Value);
        }
       
    }
   

    public class clsPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }

        public clsPerson(int ID,string name,string Description,int Age)
        {
            this.ID = ID;
            this.Name = name;
            this.Description = Description;
            this.Age = Age;

        }
    }
            

    public class Program
    {
        public static void PrintTree(TreeNode<clsPerson> node, string Indent)
        {
            Console.WriteLine(Indent + node.Value.Name);
            foreach (TreeNode<clsPerson> child in node.Children)
            {
                PrintTree(child, Indent + Indent);
            }
        }
        static void Main(string[] args)
        {
            Tree<clsPerson> GrandFather = new Tree<clsPerson>(new clsPerson(1, "Kmiti Abdelli ", "Faleg", 100));
            TreeNode<clsPerson> Oncle1 = new TreeNode<clsPerson>(new clsPerson(2, "Wajdi", "3ami Sghir", 49));
            TreeNode<clsPerson> Oncle2 = new TreeNode<clsPerson>(new clsPerson(3, "Tijani", "3ami Kbir", 49));
            TreeNode<clsPerson> Baba = new TreeNode<clsPerson>(new clsPerson(1, "Riadh", "Babaya", 61));
            TreeNode<clsPerson>Tante1 = new TreeNode<clsPerson>(new clsPerson(2, "Hayet", "3amti Kbira", 65));
            TreeNode<clsPerson> Tante2 = new TreeNode<clsPerson>(new clsPerson(2, "Mabrouka", "3amti sghira", 55));

            
            GrandFather.Root.AddChild(Oncle1);
            GrandFather .Root.AddChild(Oncle2);
            GrandFather.Root .AddChild(Tante1);
            GrandFather.Root.AddChild (Tante2);
            GrandFather.Root.AddChild(Baba);


            Oncle1.AddChild(new TreeNode<clsPerson>(new clsPerson(4, "Amen", "Kbir", 17)));
            Oncle1.AddChild(new TreeNode<clsPerson>(new clsPerson(4, "Adem", "Metwaset", 15)));
            Oncle1.AddChild(new TreeNode<clsPerson>(new clsPerson(4, "Iyed", "Sghir", 11)));
            Oncle1.AddChild(new TreeNode<clsPerson>(new clsPerson(4, "Touka", "Banouuta", 10)));


            Oncle2.AddChild(new TreeNode<clsPerson>(new clsPerson(2, "Aziz", "Azouz", 14)));
            Oncle2.AddChild(new TreeNode<clsPerson>(new clsPerson(2, "Zakaria", "Zikou", 11)));




            PrintTree(GrandFather.Root, " ");

            Console.ReadKey();
        }
    }
}
