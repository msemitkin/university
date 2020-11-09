using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeFigure
{
    class Triangle : IFigure
    {
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public IFigure Clone()
        {
            return new Triangle(a, b, c);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Трикутник зі сторонами: а = {a}, b = {b}, c = {c}");
        }
    }
}
