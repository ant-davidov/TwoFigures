using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain.Interfaces;

namespace TwoFigures.Domain
{
    public record Circle : IFigure
    {
        private double area = 0;
        public double Radius { get; init; }
        public double Area
        {
            get
            {
                if (area == 0)
                {
                    area = CalculateArea();
                    return area;
                }
                return area;
            }
        }

        public Circle(double radius)
        {
            if (radius < 0) 
                throw new ArgumentException("the radius cannot be less than zero");   
            Radius = radius;
        }

        private double CalculateArea() 
            => Math.PI * Math.Pow(Radius, 2);

    }
}
