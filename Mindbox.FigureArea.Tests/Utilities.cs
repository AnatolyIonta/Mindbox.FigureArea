using Mindbox.FigureArea.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Tests
{
    internal static class Utilities
    {
        public static double Round(double value)
        {
            return Math.Round(value, 3, MidpointRounding.ToZero);
        }
    }
}
