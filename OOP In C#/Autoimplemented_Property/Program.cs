using System;

class clsEmployee
{
    public int ID
    {
        get; 
        set;
    }
    public string Name 
    {
        get; 
        set;
    }

    static void Main(string[] args)
    {
        clsEmployee employee = new clsEmployee();
        employee.ID = 1;
        employee.Name = "Test";
        Console.WriteLine("My ID is " + employee.ID);
        Console.WriteLine("My Name is :" + employee.Name);
        Console.ReadLine();
    }
}
