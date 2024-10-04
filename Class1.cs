using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOp
{
    internal class Class1
    {
    }
    public class Person
    {
        public Person(string name, int age, int iD, DateTime startDate, double salary)
        {
            this.name = name;
            this.age = age;
            ID = iD;
            this.startDate = startDate;
            this.salary = salary;
        }

        public string name { get; set; }
        public int age { get; set; }
        public int ID { get; set; }
        public DateTime startDate { get; set; }
        public double salary { get; set; }

        public virtual void PersonalInfo()
        {
            Console.WriteLine($"Employment informatiom \n {name}\n {age} \n {ID} och \n {salary}");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Jag heter \n {name} och är {age} gammal.");

        }
        public virtual void Work()
        {
            Console.WriteLine($"{name} arbetar som i department");

        }

    }

    public class Manager : Person
    {
        public string department { get; set; }
        public Manager(string name, int age, int iD, DateTime startDate, double salary, string department) : base(name, age, iD, startDate, salary)
        {
            this.department = department;
        }
        public virtual void HoldMeeting()
        {
            base.Introduce(); // base to call the parent for information 
            Console.WriteLine($"{name} är i ett möte");

        }
        public virtual void PlanBudget()
        {
            Console.WriteLine($"{name} planerar budgeten");

        }

    }
    public class Employee : Manager
    {
        public string jobtitle { get; set; }
        public Employee(string name, int age, int iD, DateTime startDate, double salary, string department, string jobtitle) : base(name, age, iD, startDate, salary, department)
        {
            this.jobtitle = jobtitle;

        }
        public override void Work()
        {
            Console.WriteLine($"{name} arbetar som {jobtitle} och gör sitt jobb");
        }

    }
    public class Consult : Person
    {
        public double fee { get; set; }
        public string company { get; set; }

        public string expertise { get; set; }

        public Consult(string name, int age, int iD, DateTime startDate, double salary, double fee, string company, string expertise) : base(name, age, iD, startDate, salary)
        {
            this.fee = fee;
            this.company = company;
            this.expertise = expertise;
        }
        public void GiveAdvice()
        {
            Console.WriteLine($"{name} ger råd hur dom kan förbättra sin {expertise} för {fee} i timmen");
        }


    }
    public class Housekeeper : Employee
    {
        public Housekeeper(string name, int age, int iD, DateTime startDate, double salary, string department, string jobtitle) : base(name, age, iD, startDate, salary, department, jobtitle)
        {

        }
        public override void Work()
        {
            base.Work();
        }


    }
}

