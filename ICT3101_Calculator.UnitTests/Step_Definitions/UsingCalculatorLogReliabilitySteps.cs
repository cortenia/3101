using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorLogReliabilitySteps
    {
        private readonly Calculator _calc;
        private double _result;
        public UsingCalculatorLogReliabilitySteps(Calculator calc)
        {
            _calc = calc;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press Log")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLog(Decimal p0, Decimal p1, Decimal p2)
        {
            _result = _calc.LogCurrentFailureIntensity(Convert.ToDouble(p0)
                , Convert.ToDouble(p1), Convert.ToDouble(p2));
        }
        [Then(@"the Log Reliability result should be ""(.*)""")]
        public void ThenTheReliabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
