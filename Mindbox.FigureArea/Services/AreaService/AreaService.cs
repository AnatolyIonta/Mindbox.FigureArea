using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mindbox.FigureArea.Strategies;

namespace Mindbox.FigureArea.Services
{
    public class AreaService : IAreaService<double>
    {
        private IAreaStrategy<double> _strategy;
        public AreaService(IAreaStrategy<double> strategy)
        {
            _strategy = strategy;
        }

        public void SwitchStrategy(IAreaStrategy<double> strategy)
        {
            _strategy = strategy;
        }

        public double GetArea()
        {
            return _strategy.GetArea();
        }
    }
}
