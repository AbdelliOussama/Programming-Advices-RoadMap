using System;
class clsAthlete
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string SportDescription { get; set; }
    public int Age { get; set; }
    public string Category { get; set; }

    public clsAthlete(int ID,string Name,string SportDescription,int Age,string Category)
    {
        this.ID = ID;
        this.Name = Name;
        this.SportDescription= SportDescription;
        this.Age=Age;
        this.Category=Category;
    }

}

internal class program
{
    static void Main(string[] args)
    {
        clsAthlete Athlete = new clsAthlete(1,"Oussama","Boxing",24,"Senior");
        Console.WriteLine("AthleteID is {0}", Athlete.ID);
        Console.WriteLine("Athlete Name is {0}", Athlete.Name);
        Console.WriteLine("Athlete Sport is {0}", Athlete.SportDescription);
        Console.WriteLine("Athlete Age is {0}", Athlete.Age);
        Console.WriteLine("Athlete Category is {0}", Athlete.Category);
        Console.ReadKey();



    }
}

