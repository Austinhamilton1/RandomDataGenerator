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

            //get the year, month and date of the current date
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            //the start date is the date of a birthday exactly 80 years before today
            //the end date is the date of a birthday exactly 18 years before today
            DateTime startDate = new DateTime(year - 80, month, day);
            DateTime endDate = new DateTime(year - 18, month, day);

            //generate an integer in between the range of days between the two dates
            //and add that the the start date to get a new date
            int range = Convert.ToInt32(endDate.Subtract(startDate).TotalDays);
            BirthDate = startDate.AddDays(random.Next(range));

            SSN = new SSN();

            Phone = new Phone();

        }

        public int Age() 
        {
            DateTime now = DateTime.Now;
            int age = now.Year - BirthDate.Year;

            //if the current date is before the Person's birthday, subtract a year
            //as they haven't had that birthday yet
            if ((BirthDate.Month > now.Month) || (BirthDate.Month == now.Month && BirthDate.Day > now.Day))
                age--;

            return age;
        }

        public void AddDependent() 
        {
            
        }

        public override string ToString()
        {
            return $"Person: {FirstName} {LastName}\n" +
                $"Birth Date: {BirthDate.ToString()} ({Age()} years old)\n" +
                $"Social Security Number: {SSN.ToString()}\n" +
                $"Phone Number: {Phone.ToString()}\n";
        }
    }
}
