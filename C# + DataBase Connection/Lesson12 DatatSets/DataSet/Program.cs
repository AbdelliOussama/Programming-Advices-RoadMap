using System;
using System.CodeDom;
using System.Data;
using System.Linq;


namespace DataSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeeDataTable = new DataTable("EmployeeDataTable");

            EmployeeDataTable.Columns.Add("ID", typeof(int));
            EmployeeDataTable.Columns.Add("Name", typeof(string));
            EmployeeDataTable.Columns.Add("Country",typeof(string));
            EmployeeDataTable.Columns.Add("Salary", typeof(double));
            EmployeeDataTable.Columns.Add("Date", typeof(DateTime));


            EmployeeDataTable.Rows.Add(1, "Oussama", "Tunisia", 650, DateTime.Now);
            EmployeeDataTable.Rows.Add(2, "Salim", "France", 1000, DateTime.Now);
            EmployeeDataTable.Rows.Add(3, "Sarra", "Norvege", 3500, DateTime.Now);
            EmployeeDataTable.Rows.Add(4, "Asma", "Tunisia", 500, DateTime.Now);
            EmployeeDataTable.Rows.Add(5, "Asaad", "Tunisia", 0, DateTime.Now);


            DataTable DepartementDataTable = new DataTable("DepartementDataTable");

            DataColumn dtColumn;
            dtColumn=new DataColumn();

            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;

            dtColumn.Unique = true;
            dtColumn.Caption = "DepartementID";
            dtColumn.ReadOnly = true;
            DepartementDataTable.Columns.Add(dtColumn);



            dtColumn = new DataColumn();

            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.Unique = true;
            dtColumn.Caption = "DepartementName";
            dtColumn.ReadOnly = false;
            DepartementDataTable.Columns.Add(dtColumn);


            DepartementDataTable.Rows.Add(null, "IT");
            DepartementDataTable.Rows.Add(null, "Mechanical");
            DepartementDataTable.Rows.Add(null, "Translating");
            DepartementDataTable.Rows.Add(null, "Envirenematal");

            Console.WriteLine("\\Employee Data\\");
            foreach(DataRow RecordRow in EmployeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Country: {2}, Salary: {3}, Date: {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }


            Console.WriteLine("\\Departement Data\\");
            foreach (DataRow RecordRow in DepartementDataTable.Rows)
            {
                Console.WriteLine("DepartementID: {0}, DepartementName: {1} ", RecordRow["ID"], RecordRow["Name"]);
            }

            DataSet Dataset1 = new DataSet();

            Dataset1.Tables.Add(EmployeeDataTable);
            Dataset1.Tables.Add(DepartementDataTable);

            Console.WriteLine("Printing Data From The DataSet");

            foreach(DataRow RecordRow in Dataset1.Tables["EmployeeDataTable"].Rows)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Country: {2}, Salary: {3}, Date: {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }

            foreach (DataRow RecordRow in Dataset1.Tables["DepartementDataTable"].Rows)
            {
                Console.WriteLine("DepartementID: {0}, DepartementName: {1} ", RecordRow["ID"], RecordRow["Name"]);

            }



            Console.ReadKey();








        }
    }
}
