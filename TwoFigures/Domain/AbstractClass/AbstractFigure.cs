using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoFigures.Domain.Interfaces;

namespace TwoFigures.Domain.AbstractClass
{
    public abstract record AbstractFigure : IСalculateArea
    {
        public virtual double Area
        {
            get;
        }
    }
}
