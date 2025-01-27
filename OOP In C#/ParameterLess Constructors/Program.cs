using System;

class clsPerson
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPerson()
    {
        ID= 0;
        Name = "Oussama";
        Age = 24;
    }
}
internal class program
{
    static void Main(string[] args)
    {
        clsPerson Person = new clsPerson();

        Console.WriteLine("Person ID {0}", Person.ID);
        Console.WriteLine("Person Name is {0}", Person.Name);
        Console.WriteLine("Person Age is {0}", Person.Age);
        Console.ReadKey();

    }
}