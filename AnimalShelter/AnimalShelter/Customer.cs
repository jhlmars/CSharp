using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
   public  class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _isQualified;
        public string Address;
        public string Description;

        public Cat MyCat;

        public Customer(string firstname, string lastname, DateTime birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this._Birthday = birthday;
            this._isQualified =(Age >= 18);
        }
        
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value;
                _isQualified = DateTime.Now.Year - value.Year >= 18;
            }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }
        public bool IsQualified
        {
            get { return _isQualified; }
        }
        public string FullName
        {
            get { return FirstName + " " + LastName;  }
        }
    }
}
