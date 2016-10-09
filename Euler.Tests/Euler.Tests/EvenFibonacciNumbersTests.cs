using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class EvenFibonacciNumbersTests : LongInputProblemTest
    {
        public EvenFibonacciNumbersTests() : 
            base(
                tomsSolver: new Solver.Tom.EvenFibonacciNumbers(), 
                jirkasSolver: new Solver.Jirka.EvenFibonacciNumbers()
            )
        {
        }


        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(5, 2)]
        [TestCase(10, 10)]
        [TestCase(1000, 798)]
        [TestCase(4000000, 4613732)]
        [TestCase(100000000, 82790070)]
        public void CorrectnessTom(int input, int expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(5, 2)]
        [TestCase(10, 10)]
        [TestCase(1000, 798)]
        [TestCase(4000000, 4613732)]
        [TestCase(100000000, 82790070)]
        public void CorrectnessJirka(int input, int expectedResult)
        {
            CorrectnessBaseJirka(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            PerformanceBaseTom(4000000, 10000000);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(4000000, 10000000);
        }
    }
}
