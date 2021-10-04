using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    [TestFixture]
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read(@"C:\Users\stupid\source\repos\3101\ICT3101_Calculator\MagicNumbers.txt"))
                .Returns(new string[10] { "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"});
        }
        
        [Test]
        public void GenMagicNumber_WhenGivenPositiveNumber_ResultsMultipliedByTwo()
        {
            Assert.That(() => _calculator.GenMagicNum(5, _mockFileReader.Object), Is.EqualTo(8.0) );
        }
        [Test]
        public void GenMagicNumber_WhenGivenIsZero_ResultsIsZero()
        {
            Assert.That(() => _calculator.GenMagicNum(10, _mockFileReader.Object), Is.EqualTo(0));
        }


    }
    
}
