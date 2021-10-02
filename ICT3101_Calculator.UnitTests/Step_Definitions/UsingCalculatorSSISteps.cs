using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorSSISteps
    {
        private readonly Calculator _calc;
        private double _result;
        public UsingCalculatorSSISteps(Calculator calc)
        {
            _calc = calc;
        }
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(int p0, int p1, int p2)
        {
            _result = _calc.SSI(p0, p1, p2);
        }
        
        [Then(@"the SSI result should be ""(.*)""")]
        public void ThenTheSSIResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
