using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class SSN
    {
        public string Number { get; init; }

        public SSN()
        {
            Number = "123456789";
        }

        public override string ToString()
        {
            return Number.Substring(0, 3) + 
                "-" + Number.Substring(3, 2) + 
                "-" + Number.Substring(5, 4);
        }
    }
}
