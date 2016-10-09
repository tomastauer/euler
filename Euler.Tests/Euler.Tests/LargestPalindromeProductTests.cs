using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class LargestPalindromeProductTests : LongInputProblemTest
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
            PerformanceBaseTom(3, 1);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(3, 1);
        }
    }
}
