using Solver;

namespace UnitTestPracticing
{
    [TestClass]
    public class SolverTest
    {
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
    }
}