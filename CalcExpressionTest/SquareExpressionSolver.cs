using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExpressionTest
{
    public class SquareExpressionSolver
    {
        private double a;
        private double b;
        private double c;

        private double? d = null;

        public SquareExpressionSolver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Determinate
        {
            get
            {
                if (d == null)
                    d = b * b - 4 * a * c;

                return d.Value;
            }
        }

        public ComplexNum[] Calculate()
        {
            double d = Determinate;

            ComplexNum[] roots = new ComplexNum[2];

            if (d >= 0)
            {
                roots[0] = new ComplexNum((-b + Math.Sqrt(d)) / (2 * a), 0);
                roots[1] = new ComplexNum((-b - Math.Sqrt(d)) / (2 * a), 0);
            }

            else
            {
                d = Math.Abs(d);

                roots[0] = new ComplexNum(-b / (2 * a), Math.Sqrt(d) / (2 * a));
                roots[1] = new ComplexNum(-b / (2 * a), -Math.Sqrt(d) / (2 * a));
            }

            return roots;
        }
    }
}