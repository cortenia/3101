using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private readonly Calculator _calc;
        private double _result;
        public UsingCalculatorBasicReliabilitySteps(Calculator calc)
        {
            _calc = calc;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press CurrentFailureIntensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calc.CurrentFailureIntensity(Convert.ToDouble(p0)
                , Convert.ToDouble(p1), Convert.ToDouble(p2));
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press ExpectedFailureIntensity")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressExpectedFailureIntensity(int p0, int p1, int p2)
        {
            _result = _calc.ExpectedFailureIntensity(Convert.ToDouble(p0)
                , Convert.ToDouble(p1), Convert.ToDouble(p2));
        }
        
        [Then(@"the Reliability result should be ""(.*)""")]
        public void ThenTheReliabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
