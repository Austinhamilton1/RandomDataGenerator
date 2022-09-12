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
            Random random = new Random();

            FirstName = _arrayOfFirstNames[random.Next(_arrayOfFirstNames.Length)];

            //convert the values to an array and then select a random value from the array
            //convert that value to a string
            Array values = Enum.GetValues(typeof(LastName));
            LastName = (string)values.GetValue(random.Next(values.Length));

            DateTime now = DateTime.Today;
            

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
