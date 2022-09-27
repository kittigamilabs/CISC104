using System;

public class Rectangle
{
    private float height;
    private float width;

    public Rectangle()
    {
        // Default values for my instantiated rectangle.
        height = 0f;
        width = 0f;
    }

    public float GetPerimeter()
    {
        return 2 * height + 2 * width;
    }

    public float GetArea()
    {
        return height * width;
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }
}

