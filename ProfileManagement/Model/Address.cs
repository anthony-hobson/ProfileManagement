using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileManagement.Model
{
    public class Address
    {
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public Address(string streetLine1, string streetLine2, string city, string state, int zipCode)
        {
            StreetLine1 = streetLine1;
            StreetLine2 = streetLine2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
