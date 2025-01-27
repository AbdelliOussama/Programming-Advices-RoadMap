using System;
class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public clsPerson(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
     public static clsPerson Find(int ID)
    {
        if (ID == 1)
        {
            return new clsPerson(1, "Oussama", 24);
        }
        else
            return null;
    }

    public static clsPerson Find(int ID,string Name)
    {
        if (ID == 1&& Name=="Oussama")
        {
            return new clsPerson(1, "Oussama", 24);
        }
        else
            return null;
    }

}

internal class program
{
    static void Main(string[] args)
    {
        clsPerson Person1 = clsPerson.Find(1);
        if(Person1 != null)
        {
            Console.WriteLine("Finding Person By ID");
            Console.WriteLine("PersonID is {0}", Person1.Id);
            Console.WriteLine("PersonName is {0}", Person1.Name);
            Console.WriteLine("Person Age is {0}", Person1.Age);
        }
        else
        {
            Console.WriteLine("Person Not Found");
        }



        clsPerson Person2 = clsPerson.Find(1,"Oussama");
        if (Person1 != null)
        {
            Console.WriteLine("Finding Person By ID");
            Console.WriteLine("PersonID is {0}", Person2.Id);
            Console.WriteLine("PersonName is {0}", Person2.Name);
            Console.WriteLine("Person Age is {0}", Person2.Age);
        }
        else
        {
            Console.WriteLine("Person Not Found");
        }


        Console.ReadKey();
    }
}