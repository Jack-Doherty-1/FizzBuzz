using FizzBuzz.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            var calculatorTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(p => p.GetTypes())
                .Where(q => typeof(IFizzBuzzCalculator).IsAssignableFrom(q) && q.IsClass);

            foreach (var calculatorType in calculatorTypes)
            {
                _calculators.Add((IFizzBuzzCalculator)Activator.CreateInstance(calculatorType));
            }

            //If I had more time, I wouldn't use this line of code and instead would order the calculators by the divisor value.
            _calculators.Reverse();
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
