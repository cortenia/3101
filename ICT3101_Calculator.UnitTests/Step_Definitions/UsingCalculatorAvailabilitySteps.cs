using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    /*
     * 17. These functions are not well tested as they require the answers from
     * the previous steps. There is no way (that I currently know of) to pass 
     * the results from the one Gherkin feature to another.
     * (via context maybe?)
     */
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private readonly Calculator _calc;
        private double _result;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            _calc = calc;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calc.Add(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calc.Divide(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)""% into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(Decimal p0, int p1)
        {
            _result = _calc.Multiply(Decimal.ToDouble(p0), p1);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));

        }
    }
}
