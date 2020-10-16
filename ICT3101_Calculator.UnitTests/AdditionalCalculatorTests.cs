using ICT3101_Lab1;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }
        [Test]
        [TestCase(1, -0)]
        public void MagicNumber_WhenGeneratingMagicNumber_ResultEqualtoMagicNum(double a, double b)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(b));
        }
    }
}
