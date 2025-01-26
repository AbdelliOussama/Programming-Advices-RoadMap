using System;
using System.Data;
using System.Linq;

namespace DataView1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable EmployeeDataTable = new DataTable();

            DataColumn dtColumn;
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;

            dtColumn.Caption = "ID";
            dtColumn.Unique = true;
            dtColumn.ReadOnly = true;
            EmployeeDataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Name";
            dtColumn.ReadOnly = false;
            EmployeeDataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Country";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Country";
            dtColumn.ReadOnly = false;
            EmployeeDataTable.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Double);
            dtColumn.ColumnName = "Salary";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Salary";
            dtColumn.ReadOnly = false;
            EmployeeDataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);
            dtColumn.ColumnName = "Date";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Date";
            dtColumn.ReadOnly = false;
            EmployeeDataTable.Columns.Add(dtColumn);



            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = EmployeeDataTable.Columns["ID"];
            EmployeeDataTable.PrimaryKey = PrimaryKeyColumns;



            EmployeeDataTable.Rows.Add(null, "Oussama", "Tunisia", 650, DateTime.Now);
            EmployeeDataTable.Rows.Add(null, "Salim", "France", 1000, DateTime.Now);
            EmployeeDataTable.Rows.Add(null, "Sarra", "Norvege", 3500, DateTime.Now);
            EmployeeDataTable.Rows.Add(null, "Asma", "Tunisia", 500, DateTime.Now);
            EmployeeDataTable.Rows.Add(null, "Baba", "Tunisia", 1350, DateTime.Now);



            foreach (DataRow Row in EmployeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Country: {2}, Salary: {3}, Date: {4} ", Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);
            }



            DataView EmployeeDataView = EmployeeDataTable.DefaultView;
            for (int i=0;i<EmployeeDataView.Count;i++)
            {
                Console.WriteLine("{0}, {1}, {2}", EmployeeDataView[i][0], EmployeeDataView[i][1], EmployeeDataView[i][2]);
            }



            Console.WriteLine("Employee After Filtering By Country \"Tunisia\"");
            EmployeeDataView.RowFilter = "Country='Tunisia'";
            for (int i = 0; i < EmployeeDataView.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", EmployeeDataView[i][0], EmployeeDataView[i][1], EmployeeDataView[i][2]);
            }



            EmployeeDataView.Sort = "Name ASC";

            Console.WriteLine("Employee AfterSorting By Name ASC");
            for (int i = 0; i < EmployeeDataView.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", EmployeeDataView[i][0], EmployeeDataView[i][1], EmployeeDataView[i][2]);
            }

            Console.ReadKey();
        }
    }
}
