using Mindbox.FigureArea.Figure;
using Mindbox.FigureArea.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.FigureArea.Tests
{
    public class AreaServiceTest
    {
        [Fact]
        public void GetArea()
        {
            var service = new AreaService(new Triangle(3, 4, 5));

            Assert.Equal(6, service.GetArea());

            service.SwitchStrategy(new Circle(3));

            Assert.Equal(28.274, Utilities.Round(service.GetArea()));
        }
    }
}
