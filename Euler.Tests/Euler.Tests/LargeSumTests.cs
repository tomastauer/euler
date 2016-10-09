using System;
using System.IO;

using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public class LargeSumTests : StringArrayInputProblemTest
    {
        private readonly string mAssetsPath = AppDomain.CurrentDomain.BaseDirectory + "/Assets/LargeSum/";

        public LargeSumTests() : base(
            tomsSolver : new Solver.Tom.LargeSum(), 
            jirkasSolver: new Solver.Jirka.LargeSum())
        {
        }


        [TestCase("Euler.txt", 5537376230)]
        [TestCase("Test1.txt", 9)]
        [TestCase("Test2.txt", 15)]
        [TestCase("Test3.txt", 253421)]
        [TestCase("Test4.txt", 1234567890)]
        public void CorrectnessTom(string file, long expectedResult)
        {
            var input = File.ReadAllLines(Path.Combine(mAssetsPath, file));
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase("Euler.txt", 5537376230)]
        [TestCase("Test1.txt", 9)]
        [TestCase("Test2.txt", 15)]
        [TestCase("Test3.txt", 253421)]
        [TestCase("Test4.txt", 1234567890)]
        public void CorrectnessJirka(string file, long expectedResult)
        {
            var input = File.ReadAllLines(Path.Combine(mAssetsPath, file));
            CorrectnessBaseTom(input, expectedResult);
        }


        [Test]
        [Repeat(3)]
        public void PerformanceTom()
        {
            var input = File.ReadAllLines(Path.Combine(mAssetsPath, "Euler.txt"));
            PerformanceBaseTom(input, 1000);
        }


        [Test]
        public void PerformanceJirka()
        {
            var input = File.ReadAllLines(Path.Combine(mAssetsPath, "Euler.txt"));
            PerformanceBaseJirka(input, 1);
        }
    }
}
