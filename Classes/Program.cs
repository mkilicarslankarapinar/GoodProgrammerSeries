using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Bayburt";
            customer.Id = 1;
            customer.FirstName = "Kilicarslan";
            customer.LastName = "Karapinar";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "Bayburt", FirstName = "Kilicarslan", LastName = "Karapinar"
            };
            Console.WriteLine(customer2.FirstName);



        }
    }
}
