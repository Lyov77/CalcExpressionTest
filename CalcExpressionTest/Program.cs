namespace CalcExpressionTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SquareExpressionSolver solver = new SquareExpressionSolver(a: 2, b: -6, c: 5);

			solver.Solve();

		}
	}
}