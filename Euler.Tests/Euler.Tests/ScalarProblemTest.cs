﻿using System;
using System.Diagnostics;

using Euler.Solver;

using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public class ScalarProblemTest
    {
        private readonly IScalarProblemSolver mTomsSolver;
        private readonly IScalarProblemSolver mJirkasSolver;
        private const int mNumberOfRepetition = 10;


        public ScalarProblemTest(IScalarProblemSolver tomsSolver, IScalarProblemSolver jirkasSolver)
        {
            mTomsSolver = tomsSolver;
            mJirkasSolver = jirkasSolver;
        }


        protected void CorrectnessBaseTom(int input, int expectedResult)
        {
            CheckCorrectness(mTomsSolver, input, expectedResult);
        }


        protected void CorrectnessBaseJirka(int input, int expectedResult)
        {
            CheckCorrectness(mJirkasSolver, input, expectedResult);
        }


        private void CheckCorrectness(IScalarProblemSolver solver, int input, int expectedResult)
        {
            var result = solver.SolveProblem(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        

        protected void PerformanceBaseTom(int input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mTomsSolver, input, numberOfIterations);
            }
        }


        protected void PerformanceBaseJirka(int input, int numberOfIterations)
        {
            for (int i = 0; i < mNumberOfRepetition; i++)
            {
                CheckPerformance(mJirkasSolver, input, numberOfIterations);
            }
        }


        private static void CheckPerformance(IScalarProblemSolver solver, int input, int numberOfIterations)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < numberOfIterations; i++)
            {
                solver.SolveProblem(input);
            }

            stopwatch.Stop();

            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
        }
    }
}