using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Calculators
{
    internal class FizzCalculator : IFizzBuzzCalculator
    {

        private int _divisor = 3;
        private string _newValue = "Fizz";

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
