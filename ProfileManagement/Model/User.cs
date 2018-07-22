using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileManagement.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int SocialSecurityNumber { get; set; }
        public List<Address> Address { get; set; }

        public User(string firstName, string lastName, DateTime birthdate, int socialSecurity, List<Address> address)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            SocialSecurityNumber = socialSecurity;
            Address = address;
        }
    }
}
