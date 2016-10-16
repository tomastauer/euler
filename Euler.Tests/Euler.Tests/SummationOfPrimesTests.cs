using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class SummationOfPrimesTests : LongInputProblemTest
    {
        public SummationOfPrimesTests() : base(
                tomsSolver: new Solver.Tom.SummationOfPrimes(), 
                jirkasSolver: new Solver.Jirka.SummationOfPrimes()
            )
        {
        }


        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(10, 17)]
        [TestCase(29, 100)]
        [TestCase(30, 129)]
        [TestCase(53, 328)]
        [TestCase(1000, 76127)]
        [TestCase(100000, 454396537)]
        [TestCase(2000000, 142913828922)]
        public void CorrectnessTom(long input, long expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(10, 17)]
        [TestCase(29, 100)]
        [TestCase(30, 129)]
        [TestCase(53, 328)]
        [TestCase(1000, 76127)]
        [TestCase(100000, 454396537)]
        [TestCase(2000000, 142913828922)]
        public void CorrectnessJirka(long input, long expectedResult)
        {
            CorrectnessBaseJirka(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            PerformanceBaseTom(2000000, 1);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(2000000, 1);
        }
    }
}
