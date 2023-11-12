using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExpressionTest
{
	public class SquareExpressionSolver
    {
	    public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public double D { get; set; }

        public double x1 { get; set; }
        public double x2 { get; set; }

        public SquareExpressionSolver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            D = b * b - (4 * a * c);
        }

        public void Solve()
        {
            if (D > 0)
            {
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }

            else if (D == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine("x = " + x1);
            }

            else
            {
                ComplexNum x1 = new ComplexNum(-b / (2 * a), Math.Sqrt(Math.Abs(D)) / (2 * a));
                Console.WriteLine($"x1 = {x1.ToString()}");
                ComplexNum x2 = new ComplexNum(-b / (2 * a), -(Math.Sqrt(Math.Abs(D)) / (2 * a)));
                Console.WriteLine($"x2 = {x2.ToString()}");

            }
        }

        public void Show()
        {

            Console.Write($"{a}x^2 ");

            if (b > 0)
                Console.Write($"+ {b}x ");
            else
                Console.Write($"- {-b}x ");

            if (c > 0)
                Console.Write($"+ {c} ");
            else
                Console.Write($"- {-c} ");

            Console.WriteLine("= 0");
        }
    }
}
