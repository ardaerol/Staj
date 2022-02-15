using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 12, 16), FirstName = "Arda", LastName = "Erol", NationalityId = "10172175802" });
            
        }
    }
}
