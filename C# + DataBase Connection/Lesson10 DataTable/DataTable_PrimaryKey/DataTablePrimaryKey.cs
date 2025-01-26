using System;
using System.Data;
using System.Linq;

namespace DataTablePrimaryKey
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable EmployeeDataTable =new DataTable();

            EmployeeDataTable.Columns.Add("ID",typeof(int));
            EmployeeDataTable.Columns.Add("Name",typeof(string));
            EmployeeDataTable.Columns.Add("Country",typeof(string));
            EmployeeDataTable.Columns.Add("Salary", typeof(double));
            EmployeeDataTable.Columns.Add("Date", typeof(DateTime));

            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = EmployeeDataTable.Columns["ID"];
            //PrimaryKeyColumns[1]= EmployeeDataTable.Columns["Name"];
            EmployeeDataTable.PrimaryKey=PrimaryKeyColumns;


            EmployeeDataTable.Rows.Add(1, "Oussama", "Tunisia", 650, DateTime.Now);
            EmployeeDataTable.Rows.Add(2, "salim", "France", 1000, DateTime.Now);
            EmployeeDataTable.Rows.Add(3, "Asma", "Tunisia", 650, DateTime.Now);
            EmployeeDataTable.Rows.Add(4, "Sarra", "Norvege", 3500, DateTime.Now);


            foreach(DataRow Row in EmployeeDataTable.Rows)
            {
                Console.WriteLine("Employee ID : {0} ,Name: {1} ,Country: {2} ,Salary : {3} ,Date: {4}  ", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            }


            Console.ReadKey();



        }
    }
}
