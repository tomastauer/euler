using Euler.Solver.Jirka;
using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class LargestPalindromeProductTests : ScalarProblemTest
    {
        public LargestPalindromeProductTests() : base(
                tomsSolver: new Solver.Tom.LargestPalindromeProduct(), 
                jirkasSolver: new Solver.Jirka.LargestPalindromeProduct()
            )
        {
        }


        [TestCase(1, 9)]
        [TestCase(2, 9009)]
        [TestCase(3, 906609)]
        [TestCase(4, 99000099)]
        [TestCase(5, 9966006699)]
        [TestCase(6, 999000000999)]
        public void CorrectnessTom(long input, long expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(1, 9)]
        [TestCase(2, 9009)]
        [TestCase(3, 906609)]
        [TestCase(4, 99000099)]
        [TestCase(5, 9966006699)]
        [TestCase(6, 999000000999)]
        public void CorrectnessJirka(long input, long expectedResult)
        {
            CorrectnessBaseJirka(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            PerformanceBaseTom(3, 10000);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(3, 10000);
        }


        #region Jirka Tests

        [TestCase(4, true)]
        [TestCase(9, true)]
        [TestCase(10, false)]
        [TestCase(33, true)]
        [TestCase(110, false)]
        [TestCase(906609, true)]
        [TestCase(9966006699, true)]
        public void IsPalindrom_ReturnCorrect(long number, bool result)
        {
            Assert.That(new LargestPalindromeProduct().IsPalindrom(number), Is.EqualTo(result));
        }

        #endregion
    }
}
