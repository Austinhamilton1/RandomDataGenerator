using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class Phone
    {
        public string Number { get; init; }

        public Phone() 
        {
            Number = "1234567890";
        }

        public override string ToString()
        {
            return Number.Substring(0, 3) +
                "-" + Number.Substring(3, 3) +
                "-" + Number.Substring(6, 4);
        }
    }
}
