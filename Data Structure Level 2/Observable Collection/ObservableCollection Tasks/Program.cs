using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Channels;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Basic CRUD Operations:
            Create an ObservableCollection<string> for employee names. Perform Add, Remove, Update, and Clear operations.
            */
            ObservableCollection<string>Employees = new ObservableCollection<string>();
            Employees.Add("Safa");
            Employees.Add("Ghalia");
            Employees.Add("Fati");
            Employees.Add("Fattouma");
            Employees.Add("Rym");
            Employees.Add("Boss");
            Employees.Add("Nour");

            foreach (var employee in Employees)
            {
                Console.WriteLine($" Employee Name : {employee}");
            }
            Console.WriteLine(" After Remove");
            Employees.Remove("Nour");
            foreach (var employee in Employees)
            {
                Console.WriteLine($" Employee Name : {employee}");
            }
            Employees[1] = "Ghaliouta";

            Console.WriteLine("After Update");
            foreach (var employee in Employees)
            {
                Console.WriteLine($" Employee Name : {employee}");
            }

            Employees.Clear();
            Console.WriteLine("After Clear");
            foreach (var employee in Employees)
            {
                Console.WriteLine($" Employee Name : {employee}");
            }



            /*
            2.Real - Time Notification:
            Create an ObservableCollection<int> and attach an event listener to log changes to the console.
            */
            ObservableCollection<int>Numbers = new ObservableCollection<int>();
            Numbers.CollectionChanged += ItemsCollectionChanged;
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            Numbers.Add(5);
            Numbers.Add(6);
            Numbers.Add(7);
            Console.WriteLine(string.Join(",",Numbers));


            Numbers.Remove(5);
            Console.WriteLine("After Removing 5 : "+string.Join(",", Numbers));

            Numbers[1] = 60;
            Console.WriteLine("After Updating  : " + string.Join(",", Numbers));

            /*
            3. Data Binding Simulation:
            Simulate a WPF-like behavior by binding an ObservableCollection<string> to a console-based list view.
            */
            ObservableCollection<string> listViewSimulation = new ObservableCollection<string>();
            listViewSimulation.CollectionChanged += (sender, e) =>
            {
                Console.WriteLine("Updated List View:");
                foreach (var item in listViewSimulation)
                {
                    Console.WriteLine(item);
                }
            };

            listViewSimulation.Add("Item 1");
            listViewSimulation.Add("Item 2");
            listViewSimulation[1] = "Updated Item 2";
            listViewSimulation.Remove("Item 1");



            /*
            4. Sorting and Filtering with LINQ:
            Filter an ObservableCollection<int> to display numbers greater than a threshold.
            */
            ObservableCollection<int>Numbers1 = new ObservableCollection<int>();
            Numbers1.CollectionChanged += ItemsCollectionChanged;
            Numbers1.Add(30);
            Numbers1.Add(23);
            Numbers1.Add(24);
            Numbers1.Add(60);
            Numbers1.Add(58);
            Numbers1.Add(3);

            Console.WriteLine("Numbers 1 "+string.Join(",",Numbers1));

            var FilterdNumber = Numbers.Cast<int>().Where(number => number > 50);
            Console.WriteLine(" Filtered Numbers  " + string.Join(",",FilterdNumber));



            /*
            5. Custom Objects with ObsesrvableCollection:
            Create a collection of Employee objects with properties like Name and Salary. Use LINQ to filter employees with a salary above a certain amount and display the changes in the collection.
            */

            Console.ReadKey ();
        }
        public static void ItemsCollectionChanged(object sender,System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection Changed");
            switch(e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    {
                        Console.WriteLine("Added");
                        foreach(var Newitem in e.NewItems)
                        {
                            Console.WriteLine("_"+Newitem);
                        }
                        break;
                    }
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    {
                        Console.WriteLine("Removed");
                        foreach (var oldItem in e.OldItems)
                        {
                            Console.WriteLine("_" + oldItem);
                        }
                        break;
                    }
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    {
                        Console.WriteLine("Replaced");
                        foreach(var Newitem in e.NewItems)
                        {
                            Console.WriteLine("New Item"+Newitem);
                        }
                        foreach(var Olditem in e.OldItems)
                        {
                            Console.WriteLine("OldItem" + Olditem);
                        }
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    {
                        Console.WriteLine("Moved");
                        Console.WriteLine($"Moved From Old Index {e.OldStartingIndex} To New Index {e.NewStartingIndex}");

                    }
                    break;
            }
        }
    }
}
