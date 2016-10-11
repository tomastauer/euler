using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class SumSquareDifferenceTests : LongInputProblemTest
    {
        public SumSquareDifferenceTests() : base(
                tomsSolver: new Solver.Tom.SumSquareDifference(), 
                jirkasSolver: new Solver.Jirka.SumSquareDifference()
            )
        {
        }


        [TestCase(1, 0)]
        [TestCase(10, 2640)]
        [TestCase(20, 41230)]
        [TestCase(50, 1582700)]
        [TestCase(100, 25164150)]
        [TestCase(1000, 250166416500)]
        [TestCase(10000, 2500166641665000)]
        public void CorrectnessTom(long input, long expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(1, 0)]
        [TestCase(10, 2640)]
        [TestCase(20, 41230)]
        [TestCase(50, 1582700)]
        [TestCase(100, 25164150)]
        [TestCase(1000, 250166416500)]
        [TestCase(10000, 2500166641665000)]
        public void CorrectnessJirka(long input, long expectedResult)
        {
            CorrectnessBaseJirka(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            PerformanceBaseTom(100, 10000000);
        }


        [Test]
        public void PerformanceJirka()
        {
            PerformanceBaseJirka(100, 10000000);
        }
    }
}
