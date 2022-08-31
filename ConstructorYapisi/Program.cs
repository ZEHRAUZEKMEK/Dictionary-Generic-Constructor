using System;

namespace ConstructorYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); //new dendiği anda alttaki public customer çalışıyor. bunu yapmak yerine
            // Customer customer1=new Customer{Id=1, FirstName="x", LastNAme="y", City="istanbul"}; 
            //veya
            //Customer customer3=new Customer();
            //customer3.Id=3;   //bu iki yazılım aynı. 
            //veya
            //Customer customer2=new Customer(2, "z", "t", "ankara"); yazmak aynı işlevi görür. burada yazılan () metot gibi çalışır.
            //iki kullanım aynı anda olmaz. prog hata verir.

        }
        
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor:parametresi olmayan constructor
        public Customer() //eger burada parantez içine (int id, string firstName, string lastName, string city) yazılmış olsaydı
        {
            //Id=id;
            //FirstName = firstName;
            //LastName=lastNAme;
            //City=city; yazılması da gerekirdi.

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
