using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

         private static void InterfacesIntro()
            {
                PersonManager personManager = new PersonManager();
                Customer customer = new Customer
                {
                    Id = 1,
                    FirstName = "Kilic",
                    LastName = "Karapinar",
                    Address = "İstanbul"
                };

                Student student = new Student
                {
                    Id = 1,
                    FirstName = "Derin",
                    LastName = "Demiroğ",
                    Department = "Computer Sciences"
                };

                personManager.Add(student);
                personManager.Add(customer);
                Console.WriteLine(customer.Address);
            }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson iPerson)
            {
                Console.WriteLine(iPerson.FirstName);
            }
        }
    }
}
