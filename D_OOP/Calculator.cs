using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    internal class Calculator
    {
        public double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            //double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            //return square;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        //Overload error
        //public float CalcTriangleSquare(double b, double h)
        //{
        //    return (float)(0.5 * b * h);
        //}

        //public double CalcTriangleSquareByHeightAndBase(double b, double h)
        //public double CalcTriangleSquareByHeightAndBase(double b, double h)


        // ??? How do we differentiate between two methods?
        public double CalcTriangleSquare(double ab, double ac, int alpha)
        {
            //alpha in radians
            return 0.5 * ab * ac * Math.Sin(alpha);
        }
    }
}
