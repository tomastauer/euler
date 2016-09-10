﻿using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    class PrimeFactorsTests : ScalarProblemTest
    {
        public PrimeFactorsTests() : base(
                tomsSolver: new Solver.Tom.PrimeFactors(),
                jirkasSolver: new Solver.Jirka.PrimeFactors()
            )
        {
        }


        [TestCase(2, 2)]
        [TestCase(5, 5)]
        [TestCase(10, 5)]
        [TestCase(4830, 23)]
        [TestCase(600851475143, 6857)]
        public void CorrectnessTom(long input, int expectedResult)
        {
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase(2, 2)]
        [TestCase(5, 5)]
        [TestCase(10, 5)]
        [TestCase(4830, 23)]
        [TestCase(600851475143, 6857)]
        public void CorrectnessJirka(long input, int expectedResult)
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