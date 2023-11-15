namespace CalcExpressionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareExpressionSolver solver = new SquareExpressionSolver(a: 4, b: -3, c: 9);

            ComplexNum[] result = solver.Calculate();

            Console.WriteLine("Roots: {0} and {1}", result[0], result[1]);

        }
    }
}