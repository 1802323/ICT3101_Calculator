using ICT3101_Lab1;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualtoMinus()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualtoTimes()
        {
            // Act
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDividingingTwoNumbers_ResultEqualtoDivide()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(1, 40)]
        [TestCase(0, -0)]
        public void MagicNumber_WhenGeneratingMagicNumber_ResultEqualtoMagicNum(double a, double b)
        {
            double result = _calculator.GenMagicNum(a, _fileReader);
            Assert.That(result, Is.EqualTo(b));
        }
    }
}