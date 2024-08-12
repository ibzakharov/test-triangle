namespace TriangleApp;

public class TriangleException : Exception
{
    public TriangleException()
    {
    }

    public TriangleException(string message) : base(message)
    {
    }

    public TriangleException(string message, Exception inner) : base(message, inner)
    {
    }
}