using Mindbox.FigureArea.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Figure
{
    public class Circle : IAreaStrategy<double>
    {
        private readonly double _radius;
        public Circle(double radius) 
        {
            _radius = radius;
        }
        public double GetArea()
        {
            if (_radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным или равняться нулю");
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
