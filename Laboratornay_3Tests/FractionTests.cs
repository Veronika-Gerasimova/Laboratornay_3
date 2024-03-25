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

        [TestMethod]
        public void Multiply_TwoFractions_ReturnsCorrectFraction()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 3);

            Fraction result = fraction1.Multiply(fraction2);

            Assert.AreEqual(new Fraction(1, 3).ToString(), result.ToString());
        }

        [TestMethod]
        public void Divide_TwoFractions_ReturnsCorrectFraction()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 3);

            Fraction result = fraction1.Divide(fraction2);

            Assert.AreEqual(new Fraction(3, 4).ToString(), result.ToString());
        }



        [TestMethod]
        public void Simplify_Fraction_ReturnsSimplifiedFraction()
        {
            Fraction fraction = new Fraction(6, 8);
            Fraction result = fraction.Simplify();
            Assert.AreEqual(new Fraction(3, 4).ToString(), result.ToString());
        }


        [TestMethod]
        public void CompareTo_TwoFractions_ReturnsCorrectComparison()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 4);
            int result = fraction1.CompareTo(fraction2);
            Assert.AreEqual(0, result); 
        }

        [TestMethod]
        public void Add_Fractions_ReturnsMistake()
        {
            Fraction fraction1 = new Fraction(4, 2);
            Fraction fraction2 = new Fraction(1, 2);

            Fraction result = fraction1.Add(fraction2);

            Assert.IsFalse(result.Equals(fraction1));  
        }


        [TestMethod]
        public void Add_Fractions_ReturnsCorrectNumber()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 2);

            Fraction result = fraction1.Add(fraction2);

            Assert.AreEqual(new Fraction(1, 1).ToString(), result.ToString());
        }
    }
}