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
        public char Separator { get; set; }

        public Phone() 
        {
            //the min and max values for what a phone number can be
            long maxNumber = 9999999999;
            long minNumber = 2000000000;
            Random random = new Random();

            //we are going to generate a random number within the range of the min
            //and max number
            //to do this we can generate a number within their difference (+ 1 for inclusivity)
            //then add the min number to plant the number within the original range
            long number = random.NextInt64(maxNumber - minNumber + 1) + minNumber;
            Number = number.ToString();

            //the Separator is what will be shown in the text of the number
            Separator = '-';
        }

        public override string ToString()
        {
            return Number.Substring(0, 3) +
                Separator + Number.Substring(3, 3) +
                Separator + Number.Substring(6, 4);
        }
    }
}
