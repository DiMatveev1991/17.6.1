using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_7_1;
namespace Calculators.Test
{
    [TestFixture]
    public  class CalculatorTest
    {
        [Test]
        public void Subtraction_MustReturnCorrectValueSubtraction()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
        [Test]
        public void Division_MustReturnCorrectValueDivision()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }
        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
       
        [Test]
        public void Subtraction_MustReturnCorrectValueAdditional()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(300, 10) == 310);
        }
       
        [Test]
        public void Subtraction_MustReturnCorrectValueMiltiplication()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(300, 10) == 3000);
        }


    }
}
