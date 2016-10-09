using System.IO;

using NUnit.Framework;

namespace Euler.Tests
{
    [TestFixture]
    public class LargeSumTests : StringArrayInputProblemTest
    {
        private const string ASSETS_PATH = "Assets/LargeSum/";

        public LargeSumTests() : base(
            tomsSolver : new Solver.Tom.LargeSum(), 
            jirkasSolver: new Solver.Jirka.LargeSum())
        {
        }


        [TestCase("Euler.txt", 0)]
        [TestCase("Test1.txt", 9)]
        [TestCase("Test2.txt", 15)]
        [TestCase("Test3.txt", 253421)]
        [TestCase("Test4.txt", 1234567890)]
        public void CorrectnessTom(string file, int expectedResult)
        {
            var input = File.ReadAllLines(Path.Combine(ASSETS_PATH, file));
            CorrectnessBaseTom(input, expectedResult);
        }


        [TestCase("Euler.txt", 0)]
        [TestCase("Test1.txt", 9)]
        [TestCase("Test2.txt", 15)]
        [TestCase("Test3.txt", 253421)]
        [TestCase("Test4.txt", 1234567890)]
        public void CorrectnessJirka(string file, int expectedResult)
        {
            var input = File.ReadAllLines(Path.Combine(ASSETS_PATH, file));
            CorrectnessBaseTom(input, expectedResult);
        }


        [Test]
        public void PerformanceTom()
        {
            var input = File.ReadAllLines(Path.Combine(ASSETS_PATH, "Euler.txt"));
            PerformanceBaseTom(input, 10000000);
        }


        [Test]
        public void PerformanceJirka()
        {
            var input = File.ReadAllLines(Path.Combine(ASSETS_PATH, "Euler.txt"));
            PerformanceBaseJirka(input, 10000000);
        }
    }
}
