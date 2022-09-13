using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class Dependent : Person
    {
        public Dependent()
        {
            Random random = new Random();

            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year - 10, now.Month, now.Day);

            int range = Convert.ToInt32(now.Subtract(startDate).TotalDays);
            BirthDate = startDate.AddDays(random.Next(range));
        }
    }
}
