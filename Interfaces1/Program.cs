using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Arda";
            customer.LastName = "Erol";
            customer.Address = "Ümraniye";

            Student student = new Student();
            student.FirstName = "Engin";
            student.LastName = "Demiroğ";
            student.Id = 2;
            student.Departmant = "Yazılım müh.";
            


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(student);
        }
    }
}
