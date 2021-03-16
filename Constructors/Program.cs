using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,
            FirstName="Yakup İlyas",LastName="Çağan",City="Tekirdağ"};   //=
                                                         //iki kullanım eşit
            Customer customer3 = new Customer();            //=
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin",
                "Demiroğ", "Ankara");

        }
    }

    class Customer
    {
        public Customer()
        {

        }

        //default constructor
        public Customer(int id,string firstname,string lastname,string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
