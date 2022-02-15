using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("yemek ye");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("çalış");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("yemek yeğğ");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("çalış");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot çalış"); ;
        }
    }
}
