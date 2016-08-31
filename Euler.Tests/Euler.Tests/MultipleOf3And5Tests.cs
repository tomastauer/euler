using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class MultipleOf3And5Tests : ScalarProblemTest
    {
        public MultipleOf3And5Tests() : 
            base(
                tomsSolver: new Solver.Tom.MultipleOf3And5(), 
                jirkasSolver: new Solver.Jirka.MultipleOf3And5()
            )
        {
        }


        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        [TestCase(10000, 23331668)]
        [TestCase(10005, 23351670)]
        [TestCase(90000, 1889955000)]
        public void CorrectnessTom(int input, int expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        [TestCase(10000, 23331668)]
        [TestCase(10005, 23351670)]
        [TestCase(90000, 1889955000)]
        public void CorrectnessJirka(int input, int expectedResult)
        {
            CorrectnessBaseJirka(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            PerformanceBaseTom(1000, 100000000);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(4000000, 100000000);
        }
    }
}
