﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain.AbstractClass;
using TwoFigures.Domain.Interfaces;

namespace TwoFigures.Domain
{
    public sealed record Triangle : AbstractFigure
    {
        private bool? isRectangular = null;
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public bool IsRectangular 
        {
            get => IsRightAngled();       
        }
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("The sides must be greater than 0");
            if (!IsExists(a,b,c))
                throw new ArgumentException("Triangle cannot exist with such sides");
            A = a;
            B = b;
            C = c;
        }

        public static bool IsExists(double a, double b, double c) 
            => (a + b > c) && (a + c > b) && (b + c > a);

        protected override double CalculateArea()
        {
            double halfP = (A + B + C) / 2;
            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }
        private bool IsRightAngled()
        {
            if (isRectangular == null)
            {
                double[] sides = { A, B, C };
                Array.Sort(sides);
                isRectangular = Math.Pow(sides[2], 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
            }
            return isRectangular.Value;          
        }
       
    }
}

