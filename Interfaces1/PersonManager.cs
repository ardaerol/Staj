using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id +" " + person.FirstName +" "+ person.LastName);
        }
    }
}
