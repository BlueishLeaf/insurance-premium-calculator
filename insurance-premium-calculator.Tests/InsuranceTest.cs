using insurance_premium_calculator.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace insurance_premium_calculator.Tests
{
    /// <summary>
    /// Summary description for InsuranceTest
    /// </summary>
    [TestClass]
    public class InsuranceTest
    {
        private static InsuranceService _testObj;
        public InsuranceTest()
        {
            _testObj = new InsuranceService();
        }

        [TestCase(19, "apache helicopter", ExpectedResult = 0)]
        [TestCase(10, "male", ExpectedResult = 0)]
        [TestCase(60, "male", ExpectedResult = 2.5)]
        [TestCase(20, "male", ExpectedResult = 6)]
        [TestCase(10, "female", ExpectedResult = 0)]
        [TestCase(35, "female", ExpectedResult = 3.5)]
        [TestCase(20, "female", ExpectedResult = 5)]
        public double TestCalcPremium(int a, string b)
        {
            return _testObj.CalcPremium(a, b);
        }
    }
}
