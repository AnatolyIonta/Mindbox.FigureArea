using Mindbox.FigureArea.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Figure
{
    public class Triangle : IAreaStrategy<double>
    {
        private readonly double _cathetus;
        private readonly double _cathetusTwo;
        private readonly double _hypotenuse;

        public bool IsRightTriangle
        {
            get
            {
                return Math.Pow(_hypotenuse, 2) == Math.Pow(_cathetusTwo, 2) + Math.Pow(_cathetus, 2);
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide) 
        {
            var sides = new double[] { firstSide, secondSide, thirdSide};
            Array.Sort(sides);
            
            _hypotenuse = sides[2];
            _cathetus = sides[1];
            _cathetusTwo = sides[0];
        }

        public double GetArea()
        {
            if (_cathetus <= 0 || _cathetusTwo <= 0 || _hypotenuse <= 0)
            {
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной или равняться нулю");
            }

            if (IsRightTriangle)
            {
                return (_cathetus * _cathetusTwo) / 2;
            }

            if (_cathetus + _cathetusTwo > _hypotenuse && _cathetusTwo + _hypotenuse > _cathetus && _cathetus + _hypotenuse > _cathetusTwo)
            {
                double p = (_cathetus + _cathetusTwo + _hypotenuse) / 2;
                return Math.Sqrt(p * (p - _cathetus) * (p - _cathetusTwo) * (p - _hypotenuse));
            }

            throw new ArgumentOutOfRangeException("Треугольника не существует");
        }
    }
}
