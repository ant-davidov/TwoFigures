using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain.Interfaces;

namespace TwoFigures.Domain.AbstractClass
{
    public abstract record AbstractFigure : IHasArea
    {
        protected double area = 0;
        public virtual double Area
        {
            get
            {
                if (area == 0) 
                    area = CalculateArea();
                return area;
            }
        }
        protected abstract double CalculateArea();
    }
}
