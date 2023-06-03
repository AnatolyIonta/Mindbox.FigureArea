using Mindbox.FigureArea.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Tests
{
    public class СircleTest
    {
        [Fact]
        public void GetArea()
        {
            var circle = new Circle(3);
            var area = Utilities.Round(circle.GetArea());

            Assert.Equal(28.274, area);
        }
    }
}
