using Mindbox.FigureArea.Figure;
using Mindbox.FigureArea.Services;

namespace Mindbox.FigureArea.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void ClassicTriangle()
        {
            Assert.Equal(59.811, GetArea(15, 12, 10));
            Assert.Equal(59.811, GetArea(12, 15, 10));
            Assert.Equal(59.811, GetArea(12, 10, 15));
        }

        [Fact]
        public void RightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightTriangle);

            var triangle2 = new Triangle(5, 3, 4);

            Assert.True(triangle2.IsRightTriangle);

            var triangle3 = new Triangle(3, 5, 4);

            Assert.True(triangle3.IsRightTriangle);

            Assert.Equal(6, triangle.GetArea());
        }

        private double GetArea(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var area = Utilities.Round(triangle.GetArea());

            return area;
        }
    }
}