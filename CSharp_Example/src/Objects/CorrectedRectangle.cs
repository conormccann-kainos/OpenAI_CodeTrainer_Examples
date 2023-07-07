
public class Rectangle
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public int GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public bool IsSquare()
    {
        return Width == Height;
    }
}
