using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ICT3101_Calculator.UnitTests
{
    [TestFixture]
    [Parallelizable]
    class Selenium_Chrome
    {
        private string _testURL = "https://www.google.com";
        private IWebDriver _driver; // Interface for any web driver. Contract. Ensures concrete class implements required functions

        [SetUp]
        public void Start_Browser()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("--headless");
            _driver = new ChromeDriver(opt); // initialise web driver
        }
        [Test]
        public void GoogleAdd_WhenAdding2and2_ResultEquals4()
        {
            //setup
            _driver.Url = _testURL; // make a request to url
            System.Threading.Thread.Sleep(1000); // buffer time for response
            //act
            IWebElement searchBox = _driver.FindElement(By.CssSelector("[name = 'q']")); // find search box by css class name
            searchBox.SendKeys("2 + 2" + Keys.Return); // send request of "6 - 2" and "return" key press
            System.Threading.Thread.Sleep(1000); // buffer time for response
            //assert
            IWebElement calcAnswer = _driver.FindElement(By.Id("cwos")); // fetch result
            Assert.That(calcAnswer.Text, Is.EqualTo("4")); // assert
        }

        [TearDown]
        public void Close_Browser()
        {
            _driver.Quit();
        }
    }
}
