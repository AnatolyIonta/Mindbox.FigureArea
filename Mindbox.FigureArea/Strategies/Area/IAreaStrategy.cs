using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Strategies
{
    public interface IAreaStrategy<T> where T : INumber<T>
    {
        T GetArea();
    }
}
