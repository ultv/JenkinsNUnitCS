using System;
using NUnit.Framework;
using ForJenkinsIntegrate;

namespace NUnitTestProject
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void TestSumm_5_and_3_returned_8()
        {
            Calc calc = new Calc();
            int act = calc.Summ(5, 3);

            int expected = 9;

            Assert.AreEqual(act, expected);
        }

        [Test]
        public void TestSub_5_and_3_returned_2()
        {
            Calc calc = new Calc();
            int act = calc.Sub(5, 3);

            int expected = 2;

            Assert.AreEqual(act, expected);
        }

        [Test]
        public void TestSub_5_and_5_returned_0()
        {
            Calc calc = new Calc();
            int act = calc.Sub(5, 5);

            int expected = 0;

            Assert.AreEqual(act, expected);
        }
    }
}
