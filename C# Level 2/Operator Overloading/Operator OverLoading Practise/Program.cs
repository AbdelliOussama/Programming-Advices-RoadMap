using System;


namespace Operator_OverLoading_Practise
{
    public class Worker
    {
        public string name { set; get; }
        public string LastName { set; get; }    
        public string Speciality {  set; get; } 
        public DateTime DateOfStarting { set; get; }
        public int YearsOfExperience {  set; get; } 

        public Worker(string name, string lastName, string speciality, DateTime dateOfStarting, int yearsOfExperience)
        {
            this.name = name;
            this.LastName = lastName;
            this.Speciality = speciality;
            this.DateOfStarting = dateOfStarting;
            this.YearsOfExperience = yearsOfExperience;
        }

        public static bool operator ==(Worker worker1, Worker worker2)
        {
            return (worker1.name == worker2.name) && (worker1.LastName == worker2.LastName) && (worker1.Speciality == worker2.Speciality) && (worker1.YearsOfExperience == worker2.YearsOfExperience);
        }
        public static bool operator !=(Worker worker1, Worker worker2)
        {
            return (worker1.name != worker2.name) && (worker1.LastName != worker2.LastName) && (worker1.Speciality != worker2.Speciality) && (worker1.YearsOfExperience != worker2.YearsOfExperience);
        }

        public static Worker operator +(Worker worker1, Worker worker2)
        {
            return new Worker(worker1.name + worker2.name, worker1.LastName + worker2.LastName, worker1.Speciality + worker2.Speciality, worker2.DateOfStarting, worker1.YearsOfExperience + worker2.YearsOfExperience);
        }

        public  override string ToString()
        {
            return this.name +" "+ this.LastName +" "+ this.Speciality +" "+ this.DateOfStarting +" "+ this.YearsOfExperience;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker Oussama = new Worker("oussama", "Abdelli", "Medical Imaging & SoftWare Ingeneer ", DateTime.Parse("10/10/2023"),2);
            Worker Salim = new Worker("SSalim", "Abdelli", "Mechanical Ingeneer ", DateTime.Parse("10/10/2024"), 1 );

            Console.WriteLine(Oussama==Salim?"true":"false");

            Worker Baba = Oussama+Salim;
            Console.WriteLine(Baba.ToString());

            Console.ReadKey();
        }
    }
}
