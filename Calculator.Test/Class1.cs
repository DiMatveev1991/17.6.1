using NUnit.Framework;
namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100);
        }
       
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            _16._7._1.Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
    }
}
