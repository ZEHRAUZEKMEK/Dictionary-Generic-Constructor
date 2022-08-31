using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //int say1 = 10;
            //int say2 = 20;
            //say1 = say2;
            //say2 = 100;
            //Console.WriteLine("sonuc="+say1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("sonuc="+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "X";

            person2 = person1;
            person1.FirstName = "Y";
            //Console.WriteLine(person1.FirstName); //ekranda Y yazar.

            Customer customer = new Customer();
            customer.FirstName = "Z";
            customer.CreditCartNumber = "123046789";

            Employee employee = new Employee();

            Person person3 = customer; //Person employee un da customerın da adresini tutabiliyor. 
            customer.FirstName = "T";


            //Console.WriteLine(((Customer) person3).CreditCartNumber); //ekranda Z yazar.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer); //base class person olmasından ötürü sıkıntı yaşanmadı.
        }
    }

    //Base class Person. Personın içindekilerin hepsi customer ve employee da da mevcut anlamındadır.
    class Person
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
    }

    class Customer :Person
    {
        public string CreditCartNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }
    class PersonManager
    {
        public void Add(Person person) //Base class olduğu için 
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
