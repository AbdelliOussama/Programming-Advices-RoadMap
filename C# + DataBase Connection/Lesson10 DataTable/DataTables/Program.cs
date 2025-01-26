using System;
using System.Data;
using System.Linq;
using System.Threading;

namespace DataTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeeDataTable=new DataTable();
            EmployeeDataTable.Columns.Add("ID",typeof(int));
            EmployeeDataTable.Columns.Add("Name",typeof(string));
            EmployeeDataTable.Columns.Add("Country", typeof(string));
            EmployeeDataTable.Columns.Add("Salary",typeof(double));
            EmployeeDataTable.Columns.Add("Date", typeof(DateTime));


            EmployeeDataTable.Rows.Add(1, "Oussama", "Tunisia", 650, DateTime.Now);
            EmployeeDataTable.Rows.Add(2, "Salim", "France", 1000, DateTime.Now);
            EmployeeDataTable.Rows.Add(3, "Sarra", "Norvege", 3500, DateTime.Now);
            EmployeeDataTable.Rows.Add(4, "Asaad", "Tunisia", 0, DateTime.Now);
            EmployeeDataTable.Rows.Add(5, "Asma", "Tunisia", 500, DateTime.Now);
            EmployeeDataTable.Rows.Add(3, "Mama", "Tunisia", 500, DateTime.Now);


            //double EmployeesCount;
            //double TotalSalries;
            //double AverageSalaries;
            //double MinSalary;
            //double MaxSalary;

            //EmployeesCount = EmployeeDataTable.Rows.Count;
            //TotalSalries = Convert.ToDouble(EmployeeDataTable.Compute("SUM(Salary)", string.Empty));
            //AverageSalaries = Convert.ToDouble(EmployeeDataTable.Compute("AVG(Salary)", string.Empty));
            //MinSalary = Convert.ToDouble(EmployeeDataTable.Compute("MIN(Salary)", string.Empty));
            //MaxSalary = Convert.ToDouble(EmployeeDataTable.Compute("MAX(Salary)", string.Empty));


            foreach (DataRow Row in EmployeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            }


            //Console.WriteLine("Employee Numbers :  " + EmployeesCount);
            //Console.WriteLine("Total Salries :  " + TotalSalries);
            //Console.WriteLine("Average Salaries :  " + AverageSalaries);
            //Console.WriteLine("Minmum Salary :  " + MinSalary);
            //Console.WriteLine("Maximum Salary :  " + MaxSalary);


            //int ResultCount = 0;
            //DataRow[] ResultRows;

            //ResultRows = EmployeeDataTable.Select("Country='Tunisia'");

            //Console.WriteLine("Filter  \"Tunisia\" Employee ");
            //foreach (DataRow RecordRow in ResultRows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            //}



            //ResultCount = ResultRows.Count();
            //TotalSalries = Convert.ToDouble(EmployeeDataTable.Compute("SUM(Salary)", "Country='Tunisia'"));
            //AverageSalaries = Convert.ToDouble(EmployeeDataTable.Compute("AVG(Salary)", "Country='Tunisia'"));
            //MinSalary = Convert.ToDouble(EmployeeDataTable.Compute("MIN(Salary)", "Country='Tunisia'"));
            //MaxSalary = Convert.ToDouble(EmployeeDataTable.Compute("MAX(Salary)", "Country='Tunisia'"));


            //Console.WriteLine("Employee Numbers :  " + EmployeesCount);
            //Console.WriteLine("Total Salries :  " + TotalSalries);
            //Console.WriteLine("Average Salaries :  " + AverageSalaries);
            //Console.WriteLine("Minmum Salary :  " + MinSalary);
            //Console.WriteLine("Maximum Salary :  " + MaxSalary);



            //Console.WriteLine("Filter  \"Tunisia\" and \"France\" Employee ");
            //ResultRows = EmployeeDataTable.Select("Country='Tunisia' or Country='France'");

            //foreach(DataRow RecordRow in ResultRows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            //}

            //ResultCount = ResultRows.Count();
            //TotalSalries = Convert.ToDouble(EmployeeDataTable.Compute("SUM(Salary)", "Country='Tunisia' or Country='France'"));
            //AverageSalaries = Convert.ToDouble(EmployeeDataTable.Compute("AVG(Salary)", "Country='Tunisia' or Country='France'"));
            //MinSalary = Convert.ToDouble(EmployeeDataTable.Compute("MIN(Salary)", "Country='Tunisia' or Country='France'"));
            //MaxSalary = Convert.ToDouble(EmployeeDataTable.Compute("MAX(Salary)", "Country='Tunisia' or Country='France'"));

            //Console.WriteLine("Employee Numbers :  " + ResultCount);
            //Console.WriteLine("Total Salries :  " + TotalSalries);
            //Console.WriteLine("Average Salaries :  " + AverageSalaries);
            //Console.WriteLine("Minmum Salary :  " + MinSalary);
            //Console.WriteLine("Maximum Salary :  " + MaxSalary);



            //Console.WriteLine("Filter By ID=1");
            //ResultRows = EmployeeDataTable.Select("ID=1");
            //foreach (DataRow RecordRow in ResultRows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            //}

            //ResultCount = ResultRows.Count();
            //TotalSalries = Convert.ToDouble(EmployeeDataTable.Compute("SUM(Salary)", "ID=1"));
            //AverageSalaries = Convert.ToDouble(EmployeeDataTable.Compute("AVG(Salary)", "ID=1"));
            //MinSalary = Convert.ToDouble(EmployeeDataTable.Compute("MIN(Salary)", "ID=1"));
            //MaxSalary = Convert.ToDouble(EmployeeDataTable.Compute("MAX(Salary)", "ID=1"));

            //Console.WriteLine("Employee Numbers :  " + ResultCount);
            //Console.WriteLine("Total Salries :  " + TotalSalries);
            //Console.WriteLine("Average Salaries :  " + AverageSalaries);
            //Console.WriteLine("Minmum Salary :  " + MinSalary);
            //Console.WriteLine("Maximum Salary :  " + MaxSalary);


            //EmployeeDataTable.DefaultView.Sort = "ID desc";
            //EmployeeDataTable = EmployeeDataTable.DefaultView.ToTable();

            //Console.WriteLine("Employee Sorted By ID Desc");
            //foreach(DataRow RecordRow in EmployeeDataTable.Rows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            //}



            //EmployeeDataTable.DefaultView.Sort = "Name Asc";
            //EmployeeDataTable = EmployeeDataTable.DefaultView.ToTable();
            //Console.WriteLine("Employee Sorted By Name Asc");


            //foreach (DataRow RecordRow in EmployeeDataTable.Rows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            //}

            //Console.WriteLine("Employees Data After Delete ID=1");

            //DataRow[] Results = EmployeeDataTable.Select("ID=1"); ;

            //foreach(var Record in Results)
            //{
            //    Record.Delete();
            //}

            ////EmployeeDataTable.AcceptChanges(); // To Synchronise with Datasets
            //foreach (DataRow Row in EmployeeDataTable.Rows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            //}



            //Console.WriteLine("Employee After Update Umployee 1");

            //DataRow[] Results = EmployeeDataTable.Select("ID=1");
            //foreach(var Record in  Results)
            //{
            //    Record["Salary"] = 1000;
            //    Record["Date"] = new DateTime(1999/10/11);
            //}

            //foreach (DataRow Row in EmployeeDataTable.Rows)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            //}


            // To Clear DataTable Use the Predfined Methode Clear()

            EmployeeDataTable.Clear();

            foreach (DataRow Row in EmployeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0}, Name: {1} ,Country: {2}, Salary: {3} ,Date: {4}", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            }






















            Console.ReadKey();








        }
    }
}
