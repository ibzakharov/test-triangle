namespace TriangleApp.Tests;

public class TriangleTests
{
    [Fact]
    public void GetTriangleType_AcuteAngledTriangle_ReturnsAcuteAngled()
    {
        var triangle = new Triangle();
        
        var actual = triangle.GetTriangleType(60, 60, 60);
        
        Assert.Equal(TriangleType.AcuteAngled, actual);
    }

    [Fact]
    public void GetTriangleType_RightAngledTriangle_ReturnsRectangular()
    {
        var triangle = new Triangle();
        
        var actual = triangle.GetTriangleType(90, 45, 45);
        
        Assert.Equal(TriangleType.Rectangular, actual);
    }

    [Fact]
    public void GetTriangleType_ObtuseAngledTriangle_ReturnsObtuseAngled()
    {
        var triangle = new Triangle();
        
        var actual = triangle.GetTriangleType(120, 30, 30);
        
        Assert.Equal(TriangleType.ObtuseAngled, actual);
    }

    [Fact]
    public void GetTriangleType_InvalidSumOfAngles_ThrowsArgumentException()
    {
        var triangle = new Triangle();
        
        Assert.Throws<TriangleException>(() => triangle.GetTriangleType(100, 50, 50));
    }

    [Fact]
    public void GetTriangleType_NegativeOrZeroAngle_ThrowsArgumentException()
    {
        var triangle = new Triangle();
        
        Assert.Throws<TriangleException>(() => triangle.GetTriangleType(90, 90, 0));
    }
}