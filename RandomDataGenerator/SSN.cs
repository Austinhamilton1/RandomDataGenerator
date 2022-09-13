using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    internal class SSN
    {
        //https://www.ssa.gov/kc/SSAFactSheet--IssuingSSNs.pdf gives the instances
        //in which social security numbers are not valid
        public string Number { get; init; }

        public SSN()
        {
            Random random = new Random();

            //the first number can be anything in the 900 range
            string nineHundred = random.Next(900, 1000).ToString();

            //it can also be 666 or 000 so add all that to an array
            string[] possibleFirstNums = { "000", "666", nineHundred };

            string possibleSecondNums = "00";
            string possibleThirdNums = "0000";

            Number = possibleFirstNums[random.Next(possibleFirstNums.Length)] +
                possibleSecondNums + possibleThirdNums;
        }

        public override string ToString()
        {
            return Number.Substring(0, 3) + 
                "-" + Number.Substring(3, 2) + 
                "-" + Number.Substring(5, 4);
        }
    }
}
