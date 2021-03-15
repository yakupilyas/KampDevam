using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            //int, decimal, float,enum,boolen  value types
           // int sayi1 = 10;
           // int sayi2 = 20;
           // sayi1 = sayi2;

           // sayi2 = 100;

           // Console.WriteLine("Sayi 1: "+ sayi1);

            //array,class,interface referenca type
           // int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

           // sayilar1 = sayilar2;
           // sayilar2[0] = 1000;

           // Console.WriteLine(sayilar1[0]);
             
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person1 = person2;
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "123456789";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            //boxing
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personmanager = new PersonManager();
            personmanager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class: Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
