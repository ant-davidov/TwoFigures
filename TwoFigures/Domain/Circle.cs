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
            if (radius < 0) 
                throw new ArgumentException("The radius cannot be less than zero");   
            Radius = radius;
        }

        protected override double CalculateArea() 
            => Math.PI * Math.Pow(Radius, 2);

    }

}
