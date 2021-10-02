using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private readonly Calculator _calc;
        private double _result;
        public UsingCalculatorAdditionsSteps(Calculator calc)
        {
            _calc = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calc.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0)); 
        }
    }
}
