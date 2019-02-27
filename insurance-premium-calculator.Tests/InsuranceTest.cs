﻿using insurance_premium_calculator.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
    [TestClass]
    public class EndToEndTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"C:\Users\dmanf\Source\Repos\insurance-premium-calculator\insurance-premium-calculator.Tests\chromeDriver\");
            driver.Url = "http://localhost:53533";
        }

        [TestCase(19, "apache helicopter", ExpectedResult = 0)]
        [TestCase(10, "male", ExpectedResult = 0)]
        [TestCase(60, "male", ExpectedResult = 2.5)]
        [TestCase(20, "male", ExpectedResult = 6)]
        [TestCase(10, "female", ExpectedResult = 0)]
        [TestCase(35, "female", ExpectedResult = 3.5)]
        [TestCase(20, "female", ExpectedResult = 5)]
        public double test(int age, string gender)
        {
            int Age = age;
            string Ginger = gender;

            //Cut random 0 off end
            string ageAsString = age.ToString();

            //Get elements
            var ageElement = driver.FindElement(By.Name("age"));
            var genderElement = new SelectElement(driver.FindElement(By.Name("gender")));
            var submitButton = driver.FindElement(By.Name("submitButton"));

            //Set values
            genderElement.SelectByValue(gender);
            ageElement.Click();
            ageElement.SendKeys(ageAsString);
            submitButton.Click();

            //Get result
            double result = double.Parse(driver.FindElement(By.Name("result")).Text);

            //var result = resultElement.Text();
            return result;
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
