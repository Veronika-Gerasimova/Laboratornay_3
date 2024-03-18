using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratornay_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_3.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
       public void ToStringTest()
        {
            int num = 3;
            int den = 4;
            Fraction fraction = new Fraction(num, den);

            string result = fraction.ToString();

            Assert.AreEqual("3/4", result);
        }

        [TestMethod]
        public void Add_TwoFractions_ReturnsCorrectFraction()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);

            Fraction result = fraction1.Add(fraction2);

            Assert.AreEqual(new Fraction(5, 6).ToString(), result.ToString());
        }

        [TestMethod]
        public void Subtract_TwoFractions_ReturnsCorrectFraction()
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(1, 4);

            Fraction result = fraction1.Subtract(fraction2);

            Assert.AreEqual(new Fraction(1, 2).ToString(), result.ToString());
        }

    }
}