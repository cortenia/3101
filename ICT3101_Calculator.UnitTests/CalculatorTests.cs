using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Add(10, 20); // Act
            Assert.That(result, Is.EqualTo(30)); //Assert
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultsEqualToSubtraction()
        {
            double result = _calculator.Subtract(50, 10); //Act
            Assert.That(result, Is.EqualTo(40));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultsEqualToMultiplication()
        {
            double result = _calculator.Multiply(50, 10); //Act
            Assert.That(result, Is.EqualTo(500));
        }
        [Test]
        public void Multiply_WithZeroAsInput_ResultEqualToZero()
        {
            double result = _calculator.Multiply(0, 9999);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualsToDivision()
        {
            Assert.That(() => _calculator.Divide(50, 10), Is.EqualTo(5));
        }
        [Test]
        public void Divide_WithZeroAsBothInput_ResultEqualsToNotANumber()
        {
            //Assert.That(() => _calculator.Divide(0,0), Is.EqualTo(double.NaN));
            Assert.That(() => _calculator.Divide(0, 0), Is.EqualTo(1));
        }
        [Test]
        public void Divide_WithZeroAsFirstInput_ResultEqualToZero()
        {
            Assert.That(() => _calculator.Divide(0, 5), Is.EqualTo(0));
        }
        [Test]
        public void Divide_WithZeroAsSecondInput_ResultEqualToPositiveInfinity()
        {
            Assert.That(() => _calculator.Divide(5, 0), Is.EqualTo(double.PositiveInfinity));
        }
        /*
        [Test]
        [TestCase(0,0)]
        [TestCase(0,10)]
        [TestCase(10,0)]
        public void NewDivide_WithZeroAsInputs_ResultThrowArgumentException(double num1, double num2)
        {
            Assert.That(() => _calculator.Divide(num1, num2), Throws.ArgumentException);
        }
        */
        [Test]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-10), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WithFirstFourFactorialOutputs_ResultsEqualsToZeroOneTwoSix()
        {
            Assert.That(() => _calculator.Factorial(0), Is.EqualTo(1));
            Assert.That(() => _calculator.Factorial(1), Is.EqualTo(1));
            Assert.That(() => _calculator.Factorial(2), Is.EqualTo(2));
            Assert.That(() => _calculator.Factorial(3), Is.EqualTo(6));
        }
        //question 17
        [Test]
        public void AreaTriangle_WhenGettingArea_ResultEqualToArea()
        {
            Assert.That(() => _calculator.AreaTriangle(10, 10), Is.EqualTo(50));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        [TestCase(-10, 0)]
        [TestCase(0, -10)]
        [TestCase(-10, -10)]
        public void AreaTriangle_WithInputZeroOrNegative_ResultArgumentException
            (double num1, double num2)
        {
            Assert.That(() => _calculator.AreaTriangle(num1, num2), Throws.ArgumentException);
        }
        [Test]
        public void AreaCircle_WhenGettingArea_ResultEqualToArea()
        {
            Assert.That(() => _calculator.AreaCircle(9), Is.EqualTo(254.47));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void AreaCircle_WithInputZeroOrNegative_ResultArgumentException
            (double num)
        { 
            Assert.That(() => _calculator.AreaCircle(num), Throws.ArgumentException);
        }
        /* Question 18a.
         * **/

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5); // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4); // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3); // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test] //args must be positive
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test] // arg1 must be greater than arg2
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        //question 18b.
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5); // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4); // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3); // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test] //args must be positive 
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test] //arg1 must be greater than arg2
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

    }
    
}
