using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roscosoft.Administration.Library.DomainContracts;
using Roscosoft.Administration.Library.DomainImplementations;
using System.Collections.Generic;

namespace Roscosoft.Administration.Library.UnitTest
{
    [TestClass]
    public class When_Arithmetic_Test
    {
        public IArithmeticService ArithmeticService;

        [TestInitialize]
        public void Initialize()
        {
            this.ArithmeticService = new ArithmeticService();
        }

        [TestMethod]
        public void When_Sum_Then_15()
        {
            decimal value1 = 5;
            decimal value2 = 10;

            var result = ArithmeticService.TwoValuesSum(value1, value2);

            Assert.IsTrue(result == 15);
        }

        [TestMethod]
        public void When_multiple_numbers_Then_271()
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(1);
            numbers.Add(7);
            numbers.Add(1);
            numbers.Add(10);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(14);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(234);

            var result = ArithmeticService.ListValuesSum(numbers);

            Assert.IsTrue(result == 271);
        }

        [TestMethod]
        public void When_Negative_Number_To_Sum_Then_Minus_5()
        {
            decimal value1 = 5;
            decimal value2 = -10;

            var result = ArithmeticService.TwoValuesSum(value1, value2);

            Assert.IsTrue(result == -5);
        }

        [TestMethod]
        public void When_Quadratic_Equation_Then_Two_Results()
        {
            decimal a = 2;
            decimal b = 5;
            decimal c = -10;

            var result = ArithmeticService.QuadraticEquationType1(a, b, c);

            Assert.IsTrue(result.Item1 == 0.12347538297979899);
            Assert.IsTrue(result.Item2 == -10.123475382979798);
        }

        [TestMethod]
        public void When_Quadratic_Equation_Then_One_Result()
        {
            decimal a = 5;
            decimal b = -10;
            decimal c = 0;

            var result = ArithmeticService.QuadraticEquationType1(a, b, c);

            Assert.IsTrue(result.Item1 == 13.16227766016838);
            Assert.IsTrue(result.Item2 == 6.83772233983162);
        }

        [TestMethod]
        public void When_Substract_Then_15()
        {
            decimal value1 = 20;
            decimal value2 = 5;

            var result = ArithmeticService.TwovaluesSubstract(value1, value2);

            Assert.IsTrue(result == 15);
        }

        [TestMethod]
        public void When_Substract_Multiple_Numbers_Then_10()
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(40);
            numbers.Add(20);
            numbers.Add(10);

            var result = ArithmeticService.ListValuesSubstract(numbers);

            Assert.IsTrue(result == 10);
        }

        [TestMethod]
        public void When_Multiplication_Then_100()
        {
            decimal value1 = 20;
            decimal value2 = 5;

            var result = ArithmeticService.TwovaluesMultiplication(value1, value2);

            Assert.IsTrue(result == 100);
        }

        [TestMethod]
        public void When_Multiplication_Multiple_Numbers_Then_9000()
        {
            List<decimal> numbers = new List<decimal>();
            numbers.Add(30);
            numbers.Add(30);
            numbers.Add(10);

            var result = ArithmeticService.ListValuesMultiplication(numbers);

            Assert.IsTrue(result == 9000);
        }

        [TestMethod]
        public void When_Division_Then_4()
        {
            decimal value1 = 20;
            decimal value2 = 5;

            var result = ArithmeticService.TwovaluesDivision(value1, value2);

            Assert.IsTrue(result == 4);
        }
    }
}
