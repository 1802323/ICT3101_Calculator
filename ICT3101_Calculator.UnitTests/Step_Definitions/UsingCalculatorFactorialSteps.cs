using ICT3101_Lab1;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorFactorialSteps(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factoroial result should be ""(.*)""")]
        public void ThenTheFactoroialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
