using System;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{FirsName="Engin"+" ",LastName="Demiroğ", },
                new Student{FirsName="Arda"+" ", LastName="Erol"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirsName+person.LastName);
            }

            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string City { get; set; }

    }

    class Student:Person
    {
        public string Department { get; set; }
    }
}
