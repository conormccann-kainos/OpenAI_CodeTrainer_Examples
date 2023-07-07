
public class Rectangle
{
    public int Width;
    public int Height;

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
        if (Width == Height)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
