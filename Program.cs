using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> personallistatwo = new List<Person>();
            List<Person> personallista = new List<Person> 
            
            {   new Person("Erik", 35, 267492, new DateTime(2019, 12, 04), 36.000),
                new Manager("Bossman", 67, 267492, new DateTime(2019, 12, 04), 36.000, "managment"),
                new Employee("Eva", 30, 267492, new DateTime(2019, 12, 04), 36.000, "managment", "receptionist"),
                new Consult("Anna", 23, 267492, new DateTime(2019, 12, 04), 36.000, 1500, "Hotell Experterna AB", "logistik"),
                new Housekeeper("Elin", 32, 267492, new DateTime(2019, 12, 04), 36.000, "cleaning", "cleaner")

            };


            Person anställdx = new Person("Erik", 35, 267492, new DateTime(2019, 12, 04), 36.000);
            anställdx.Introduce();
            Manager chef = new Manager("Bossman", 67, 267492, new DateTime(2019, 12, 04), 36.000, "managment");
            chef.HoldMeeting();
            chef.PlanBudget();
            Employee anstäldz = new Employee("Eva", 30, 267492, new DateTime(2019, 12, 04), 36.000, "managment", "receptionist");
            anstäldz.Work();
            Consult anställdv = new Consult("Anna", 23, 267492, new DateTime(2019, 12, 04), 36.000, 1500, "Hotell Experterna AB", "logistik");
            anställdv.GiveAdvice();
            Housekeeper anstäldj = new Housekeeper("Elin", 32, 267492, new DateTime(2019, 12, 04), 36.000, "cleaning", "cleaner");
            anstäldj.Work();

      
            personallistatwo.Add(anställdx);
            personallistatwo.Add(chef);
            personallistatwo.Add(anstäldz);
            personallistatwo.Add(anställdv);
            personallistatwo.Add(anstäldj);

            foreach (var item in personallista)
            {
                item.PersonalInfo();
                item.Introduce();
            }
            double averageAge = personallista.Average(x=>x.age);
            Console.WriteLine($"Genomsnittlig ålder på personalen:{averageAge}");


        }
    }
}
