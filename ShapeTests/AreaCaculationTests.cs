namespace ShapeTests
{
    public class AreaCaculationTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);

            Assert.That(circle.CalculateArea(), Is.EqualTo(78.53981633974483).Within(0.00001));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.00001));
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightAngled());
        }

        [Test]
        public void CompliteTimeCaculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            AreaCaculator caculator = new AreaCaculator(triangle);

            Assert.That(caculator.CalculateArea(), Is.EqualTo(6).Within(0.00001));
        }
    }
}