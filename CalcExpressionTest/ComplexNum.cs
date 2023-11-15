using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExpressionTest
{
    public class ComplexNum
    {
        private readonly double real;
        private readonly double imaginary;

        public ComplexNum(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            char sim = imaginary >= 0 ? '+' : '-';
            double absImg = Math.Abs(imaginary);

            return $"{real} {sim} {absImg}i";
        }

        public override bool Equals(object? obj)
        {
            ComplexNum? complex = obj as ComplexNum;

            if (complex == null)
            {
                return false;
            }

            return real == complex.real && imaginary == complex.imaginary;
        }

        public override int GetHashCode()
        {
            return real.GetHashCode() ^ imaginary.GetHashCode();
        }

        public static bool operator ==(ComplexNum? complex1, ComplexNum? complex2)
        {
            return complex1?.Equals(complex2) ?? false;
        }

        public static bool operator !=(ComplexNum complex1, ComplexNum complex2)
        {
            return !complex1.Equals(complex2);
        }

        public static ComplexNum operator +(ComplexNum complex1, ComplexNum complex2)
        {
            return new ComplexNum(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
        }

        //public static implicit operator double(ComplexNum complex)
        //{
        //    if (complex.imaginary != 0)
        //        throw new InvalidCastException("Cast is not allowed: Imiginary is not null");

        //    return complex.real;
        //}
    }
}