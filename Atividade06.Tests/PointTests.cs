using System.Drawing;

namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void DistanceToPoints_WithNotNullPoint_ReturnDistance()
        {
            var point1 = new Point(2.0, 3.0);
            var point2 = new Point(5.0, 1.0);

            var result = point1.DistanceTo(point2);

            Assert.Equal(result, Math.Sqrt(13));
        }

        [Fact]
        public void DistanceToPoints_WithNullPoint_ThrowsArgumentNullException()
        {
            var point1 = new Point(2.0, 3.0);

            var exception = Assert.Throws<ArgumentNullException>(() => point1.DistanceTo(null));
            Assert.Equal(exception.Message, "Argument must be a Point (Parameter 'other')");
        }
    }
}