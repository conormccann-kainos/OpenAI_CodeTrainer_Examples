
using NUnit.Framework;

[TestFixture]
public class RectangleTests
{
    [Test]
    public void TestRectangle()
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Assert.AreEqual(5, rectangle.Width);
        Assert.AreEqual(10, rectangle.Height);
        Assert.AreEqual(50, rectangle.GetArea());
        Assert.AreEqual(30, rectangle.GetPerimeter());
        Assert.IsFalse(rectangle.IsSquare());
    }
}
