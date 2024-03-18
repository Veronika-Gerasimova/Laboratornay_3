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

    }
}