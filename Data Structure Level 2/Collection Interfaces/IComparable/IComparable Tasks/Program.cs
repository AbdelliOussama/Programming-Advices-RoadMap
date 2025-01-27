using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IComparable_Tasks
{

    /*
    Task 1: Compare Books by Title Length
    Create a Book class with Title and Author properties.
    Implement IComparable to sort books by the length of their titles.
    */

    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }

        public Book(string Title, string Description, string AuthorName, string AuthorEmail)
        {
            this.Title = Title;
            this.Description = Description;
            this.AuthorName = AuthorName;
            this.AuthorEmail = AuthorEmail;
        }
        int IComparable<Book>.CompareTo(Book other)
        {
            return this.Title.Length.CompareTo(other.Title.Length);
        }

        public override string ToString()
        {
            return $"Title : {this.Title} Description : {this.Description} Author Name : {this.AuthorName}";
        }
    }
    /*
    Task 2: Sort Students by Grades
    Create a Student class with Name and Grade properties.
    Sort a list of students in descending order of their grades.
    */
    public class clsStuddent : IComparable<clsStuddent>
    {
        public string Name {  get; set; }
        public float Grade { get; set; }
        public clsStuddent(string Name, float Grade)
        {
            this.Name = Name;
            this.Grade = Grade;
        }
        public override string ToString()
        {
            return $"Student Name : {Name}  Grade : {Grade} ";
        }
        public int CompareTo(clsStuddent other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
    }

    /*
    Task 3: Multi-level Sorting
    Create an Employee class with Name, Department, and Salary.
    Sort employees by Department, then by Salary within each department.
    */
    public class clsEmployee : IComparable<clsEmployee>
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary {  get; set; }

        public clsEmployee(string name, string department, double salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Employee Name : {Name}, Department : {Department} , Salary : {Salary}";
        }

        public int CompareTo(clsEmployee other)
        {
            if (other == null) return 1 ;

            if(this.Department == other.Department)
            {
                return this.Salary.CompareTo(other.Salary);
            };
            return this.Department.CompareTo(other.Department);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>();
            list.Add(new Book("Mastering LINQ in C#", "A deep dive into Language Integrated Query (LINQ) in C#, with practical examples and use cases.", "Jane Smith", "jane.smith@codingworld.com"));
            list.Add(new Book("Introduction to .NET Core", "An advanced programming course focusing on multithreading, memory management, and performance optimization in C#.", "Emily Davis", "michael.brown@dotnetpro.com"));
            list.Add(new Book("Advanced C# Programming", "A deep dive into Language Integrated Query (LINQ) in C#, with practical examples and use cases.", "Jane Smith", "emily.davis@techbytes.com"));


            foreach (Book book in list)
            {
                Console.WriteLine(book.ToString());
            }


            list.Sort();
            Console.WriteLine(" Books After Sorting ");
            foreach (Book book in list)
            {
                Console.WriteLine(book.ToString());
            }


            Console.WriteLine("\n ______________________ Task 2 ________________________________________\n");


            List<clsStuddent> Students = new List<clsStuddent>()
            {
                new clsStuddent("Zahra",13),
                new clsStuddent("Asma ",15),
                new clsStuddent ("Houssam",18),
                new clsStuddent ("Oussama",20),
                new clsStuddent("Rami",18),

            };

            foreach(clsStuddent student in Students)
                { Console.WriteLine(student.ToString()); }


            Console.WriteLine("\n _____________________ After Sorting __________________________\n");
            Students.Sort();
            Students.Reverse();

            foreach (clsStuddent student in Students)
            { Console.WriteLine(student.ToString()); }


            Console.WriteLine("\n ______________________ Task 3 ________________________________________\n");

            List<clsEmployee> Employees = new List<clsEmployee>()
            {
                new clsEmployee("Oussama","HealthCare && IT",5000),
                new clsEmployee("Salim ","Mechanical Ingneering",5000),
                new clsEmployee("Sarra","Geology",3500),
                new clsEmployee("Asma","Education && Translating",4000)
            };

            foreach (clsEmployee employee in Employees)
            { Console.WriteLine(employee.ToString()); }

            Console.WriteLine("\n _____________________ After Sorting __________________________\n");
            Employees.Sort();
            foreach (clsEmployee employee in Employees)
            { Console.WriteLine(employee.ToString()); }


            Console.ReadKey();


        }
    }

       
}
