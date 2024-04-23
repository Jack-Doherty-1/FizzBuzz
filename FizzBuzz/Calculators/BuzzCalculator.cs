using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Calculators
{
    internal class BuzzCalculator : IFizzBuzzCalculator
    {
        private int _divisor = 5;
        private string _newValue = "Buzz";

        public string CheckValue(int i)
        {
            if(i % _divisor == 0)
            {
                return _newValue;
            }

            return "";
        }
    }
}
