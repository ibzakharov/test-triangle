namespace TriangleApp;

public class Triangle
{
    public TriangleType GetTriangleType(double a, double b, double c)
    {
        const double epsilon = 1e-10; 

        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new TriangleException("One of the angles is less than or equal to 0");
        }

        if (Math.Abs(a + b + c - 180) > epsilon)
        {
            throw new TriangleException("Sum of angles is not equal to 180 degrees");
        }

        if (Math.Abs(a - 90) < epsilon || Math.Abs(b - 90) < epsilon || Math.Abs(c - 90) < epsilon)
        {
            return TriangleType.Rectangular;
        }

        if (a < 90 && b < 90 && c < 90)
        {
            return TriangleType.AcuteAngled;
        }

        return TriangleType.ObtuseAngled;
    }
}