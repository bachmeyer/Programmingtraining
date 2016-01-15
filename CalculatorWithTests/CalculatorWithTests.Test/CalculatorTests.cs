using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorWithTests.Test
{
    [TestClass]
    public class CalculatorTests
    {

        [TestMethod]
        public void TestAddNumbers()
        {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.AddNum1(5, 4, 3, 2, 1);
            //assert
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestSubNumbers() {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.SubNum2(13, 17);
            //assert
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void TestMultNumbers() {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.MultNum(13, 17);
            //assert
            Assert.AreEqual(221, result);
        }
        [TestMethod]
        public void TestDivNumbers() {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.DivNum(25, 5);
            //assert
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestDivByZero()
        {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.DivNum(17, 0);
            //assert
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [TestMethod]
        public void TestDivWithNegatives()
        {
            //arrange
            var calc = new Calculator();
            //act
            var result = calc.DivNum(-20, 5);
            //assert
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void TestExponential()
        {
            var calc = new Calculator();
            var result = calc.Exp(2, 10);
            Assert.AreEqual(1024, result);

        }
        [TestMethod]
        public void TestExponentialNegativeBaseEvenExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, 10);
            Assert.AreEqual(1024, result);

        }
        [TestMethod]
        public void TestExponentialNegativeBaseOddExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, 9);
            Assert.AreEqual(-512, result);

        }
        [TestMethod]
        public void TestExponentialNegativeBaseNegatveEvenExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, -10);
            Assert.AreEqual(.0009765625, result);

        }
        [TestMethod]
        public void TestExponentialNegatveBaseNegativeOddExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(-2, -3);
            Assert.AreEqual(-.125, result);

        }
        [TestMethod]
        public void TestExponentialPositiveOddExp()
        {
            var calc = new Calculator();
            var result = calc.Exp(2, -3);
            Assert.AreEqual(.125, result);

        }
    }
}
