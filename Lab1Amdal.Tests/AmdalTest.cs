using NUnit.Framework;
using Lab1Amdal;

namespace Tests
{
    public class Tests
    {
        [TestCaseSource("Cases")]
        public void AmdalRTest(Amdal amdal, double expected)
        {
            double actual = amdal.R;
            Assert.AreEqual(expected, actual);
        }

        static object[] Cases =
        {
            new object[] { new Amdal(0.7, 0, 0, 1), 1 },
            new object[] { new Amdal(1, 0, 0, 34), 1 },
            new object[] { new Amdal(1, 1, 1, 88), 0.5 },
        };
    }
}