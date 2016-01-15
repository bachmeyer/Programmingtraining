using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpobjects
{
    class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age
        {

            get
            {
                return (int)((DateTime.Now - BirthDate).Days / 365.25);
            }
        }
        public DateTime BirthDate { get; set; }
    }
}


