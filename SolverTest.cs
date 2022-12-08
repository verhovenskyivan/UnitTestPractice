using Solver;

namespace UnitTestPracticing
{
    [TestClass]
    public class SolverTest
    {

        void TestEquation(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
        [TestMethod]
        public void OrdinaryEquation()
        {
            var a = 1;
            var b = -3;
            var c = 2;

            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        public void NegativeDescriminant()
        {
            var a = 1;
            var b = 1;
            var c = 1;

            var result = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void ZeroDiscriminant()
        {
            TestEquation(1, 2, 1,-1);
        }
        [TestMethod]
        public void NegativeDiscriminant()
        {
            TestEquation(1, 1, 1);
        }
        [TestMethod]
        public void ZeroA()
        {
            TestEquation(0, -1, 1, 1);
        }
        [TestMethod]
        public void ZeroAandB()
        {
            TestEquation(0, 0, 1);
        }
        [TestMethod]
        public void FunctionalTest()
        {
            var rnd = new Random();
            var a = rnd.NextDouble() * 10;
            var b = rnd.NextDouble() * 10;
            var c = rnd.NextDouble() * 10;
            var result = QuadraticEquationsSolver.Solve(a, b, c);
            foreach(var x in result )
            {
                Assert.AreEqual(0, a * x * x + b * x + c, 1e-10);
            }
        }
    }
}