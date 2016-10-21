using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourOfCSharp6
{
    public class Company
    {
        public Person ContactPerson { get; set; }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName(bool lastNameFirst) =>
            (lastNameFirst) ? LastName + ", " + FirstName :
            FirstName + " " + LastName;
        public Address HomeAddress { get; set; }
    }
    public class Address
    {
        public string LineOne { get; set; }

    }
}
