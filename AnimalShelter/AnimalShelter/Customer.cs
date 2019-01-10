using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Customer
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;
        public string Description;

        public Customer(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }
    }
}
