using System ;
public class clsPerson
{
    public string FirstName { get; set; }
    public string LastName {  get; set; }
    public int ID { get; set; }

    public clsPerson(string FirstName, string LastName, int ID)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.ID = ID;
    }

    public void FullInfo()
    {
        Console.WriteLine($"Person Info {this.FirstName} {this.LastName}{this.ID}");
    }
    public class clsEmployee : clsPerson
    {
        public string Occupation { get; set; }
        public int Salary { get; set; }
        public int Sale { get; set; }

        public void printEmployyeInfo()
        {
            Console.WriteLine("FirstName is{0} LastName is {1} ID {2} Occupation {3} Salary{4}" ,this.FirstName,this.LastName,this.ID,this.Occupation,this.Salary);
        }

        public clsEmployee(string occupation, int salary, int sale,string FirstName,string LastName,int ID):base(FirstName,LastName,ID)
        {
            Occupation = occupation;
            Salary = salary;
            Sale = sale;
        }
    }

    

}

internal class program
{
    static void Main(string[] args)
    {
        clsPerson person = new clsPerson("Oussama", "Abdelli", 1);

        person.FullInfo();
        clsPerson.clsEmployee Employee = new clsPerson.clsEmployee("Software Ingeneer", 450, 120, "Oussama", "Abdelli", 1);
        Employee.printEmployyeInfo();
        Console.ReadKey();

    }
}