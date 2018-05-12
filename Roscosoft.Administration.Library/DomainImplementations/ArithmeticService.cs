using Roscosoft.Administration.Library.DomainContracts;
using System;
using System.Collections.Generic;

namespace Roscosoft.Administration.Library.DomainImplementations
{
    public class ArithmeticService : IArithmeticService
    {
        public ArithmeticService()
        {

        }

        public decimal TwoValuesSum(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal ListValuesSum(List<decimal> numbers)
        {
            decimal result = 0;

            foreach (var number in numbers)
            {
                result += number;

            }

            return result;
        }
        
        public decimal TwovaluesSubstract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }

        public decimal TwovaluesMultiplication(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public decimal TwovaluesDivision(decimal value1, decimal value2)
        {
            return value1 / value2;
        }

        public decimal ListValuesSubstract(List<decimal> numbers)
        {
            decimal result = 0;

            foreach (var number in numbers)
            {
                result = (result == 0)
                    ? result = number
                    : result - number;
            }

            return result;
        }

        public decimal ListValuesMultiplication(List<decimal> numbers)
        {
            decimal result = 1;

            foreach (var number in numbers)
            {
                result *= number;
            }

            return result;
        }

        public Tuple<double, double> QuadraticEquationType1(decimal a, decimal b, decimal c)
        {
            var result1 = (double)-b + Math.Sqrt((double)(((b * b) - (4 * a * c)) / (2 * a)));
            var result2 = (double)-b - Math.Sqrt((double)(((b * b) - (4 * a * c)) / (2 * a)));
            
            return new Tuple<double, double>(result1, result2);
        }
    }
}
