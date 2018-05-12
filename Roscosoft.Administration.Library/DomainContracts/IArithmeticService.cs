using System;
using System.Collections.Generic;

namespace Roscosoft.Administration.Library.DomainContracts
{
    public interface IArithmeticService
    {
        decimal TwoValuesSum(decimal value1, decimal value2);

        decimal TwovaluesSubstract(decimal value1, decimal value2);

        decimal TwovaluesMultiplication(decimal value1, decimal value2);

        decimal TwovaluesDivision(decimal value1, decimal value2);

        decimal ListValuesSum(List<decimal> numbers);

        decimal ListValuesSubstract(List<decimal> numbers);

        decimal ListValuesMultiplication(List<decimal> numbers);

        Tuple<double, double> QuadraticEquationType1(decimal a, decimal b, decimal c);

    }
}
