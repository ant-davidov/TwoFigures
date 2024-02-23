using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain.AbstractClass;
using TwoFigures.Domain.Interfaces;

namespace TwoFigures.Domain
{
    public sealed record Circle : AbstractFigure
    {
        public double Radius { get; init; }
        public Circle(double radius)
        {
            if (radius < double.Epsilon)
                throw new ArgumentException("The radius must be greater than zero");
            Radius = radius;
            area = CalculateArea();
        }

        protected override double CalculateArea()
        {
            var result = Math.PI * Math.Pow(Radius, 2);
            if (double.IsInfinity(result)) 
                throw new ArgumentException("The radius is too large, it is impossible to calculate the area");
            if (0.0 == result)
                throw new ArgumentException("The radius is too small, it is impossible to calculate the area");
            return result;
        }
    }

}
