using System;
// 4ncü gün Odev2
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // default cons çalışıyo
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin",
                LastName = "Demiroğ",
                City = "Ankara" };
            // default Cons çalışıyor
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }

        static void Method(int id, string firstName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
