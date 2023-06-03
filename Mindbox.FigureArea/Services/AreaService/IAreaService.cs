using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Mindbox.FigureArea.Strategies;

namespace Mindbox.FigureArea.Services
{
    public interface IAreaService<T> where T : INumber<T>
    {
        void SwitchStrategy(IAreaStrategy<T> strategy);
        double GetArea();
    }
}
