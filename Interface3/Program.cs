using System;

namespace Interface3
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);

            projectManager.Update(customerManager);
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();

        void Update();
    }

    //inherits-class ---------------- implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager )
        {
            
            personManager.Add();

            
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
