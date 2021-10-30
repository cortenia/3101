using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Firefox;

namespace ICT3101_Calculator.UnitTests
{
    [TestFixture]
    [Parallelizable]
    class Selenium_Firefox
    {
        private string _testURL = "https://www.google.com";
        private IWebDriver _driver; // Interface for any web driver. Contract. Ensures concrete class implements required functions

        [SetUp]
        public void Start_Browser()
        {
            //geckodriver proxy between selenium and browser
            /*
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\stupid\Downloads\geckodriver-v0.30.0-win64", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe"; 
            */
            FirefoxOptions opt = new FirefoxOptions();
            opt.AddArgument("--headless");
            //_driver = new FirefoxDriver(service, opt); // initialise web driver
            _driver = new FirefoxDriver(opt);
        }
        /*
         * DEPENDING ON HOW FAST THE WEBDRIVER LOADS THE PAGE
         * MAY OR MAY NOT NEED SLEEP
         * CHROME DOESNT
         * FIREFOX DOES
         * HEADLESS REDUCES OVERHEAD, SO IT REQUIRES LESS TIME
         */

        [Test]
        public void GoogleSubtract_WhenSubtracting2from6_ResultEquals4()
        {
            //setup
            _driver.Url = _testURL; // make a request to url
            System.Threading.Thread.Sleep(1000); // buffer time for response
            //act
            IWebElement searchBox = _driver.FindElement(By.CssSelector("[name = 'q']")); // find search box by css class name
            searchBox.SendKeys("6 - 2" + Keys.Return); // send request of "6 - 2" and "return" key press
            System.Threading.Thread.Sleep(1000); // buffer time for for response
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
