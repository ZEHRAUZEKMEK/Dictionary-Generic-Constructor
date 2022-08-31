using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> DicList = new Dictionary<int, string>();

            var customers = new Dictionary<int, string>();
            customers.Add(0, "X");
            customers.Add(1, "Y");
            customers.Add(2, "Z");
            customers.Add(3, "T");
            customers.Add(4, "W");
            customers.Add(5, "S");

            foreach (var customer in customers)
            {
                Console.WriteLine("ID="+customer.Key+ " "+"Name="+customer.Value);
            }
            string newCustomer = "A";
            bool IsThereaNewCustomer = customers.TryGetValue(10, out newCustomer);

            if(IsThereaNewCustomer)
            {
                Console.WriteLine("Bu ID numarasına sahip bir müşteri mevcuttur.");
            }
            else
            {
                newCustomer = "A";
                customers.Add(10, newCustomer);
                Console.WriteLine($"ID= {customers.Keys.Last()} Name={customers.Values.Last()}");
                Console.WriteLine("Ekleme işlemi başarı ile gerçekleşmiştir.");

            }
        }
        
    }
}
