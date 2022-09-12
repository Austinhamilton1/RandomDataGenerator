using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class Person
    {
        string[] _arrayOfFirstNames = {
                "John",
                "Alex",
                "Jill",
                "George",
                "Alice",
                "Margaret",
                "Philip",
                "Howard",
                "Jack",
                "Pam"
        };
        Dependent[] _dependents;

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }

        public Person()
        {

        }

        public int Age() 
        { 

        }

        public void AddDependent() 
        {
            
        }

        public override string ToString()
        {

        }
    }
}
