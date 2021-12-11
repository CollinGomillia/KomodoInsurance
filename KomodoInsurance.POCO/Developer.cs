using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCO
{
    public class Developer
    {
        public Developer()
        {

        }

        public Developer(int id, string firstName, string lastName, bool haveAccess)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HaveAccess = haveAccess;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HaveAccess { get; set; }
        

    }
}
