using FizzBuzz.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        private List<IFizzBuzzCalculator> _calculators;

        public FizzBuzzService()
        {
            _calculators = new List<IFizzBuzzCalculator>();
            _calculators.Add(new FizzCalculator());
        }

        public string GetFizzBuzzValue(int i)
        {
            string fizzBuzzValue = "";

            foreach(IFizzBuzzCalculator calculator in _calculators)
            {
                fizzBuzzValue += calculator.CheckValue(i);
            }

            if(fizzBuzzValue.Length == 0)
            {
                fizzBuzzValue = i.ToString();
            }

            return fizzBuzzValue;
        }
    }
}
