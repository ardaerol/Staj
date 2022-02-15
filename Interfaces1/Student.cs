using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
}
