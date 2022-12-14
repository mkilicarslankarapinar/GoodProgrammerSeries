using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Kilic" }, 
                new Student{FirstName="Karapinar"},
                new Person{FirstName="Muhammet"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string City { get; set; }
    }
}
