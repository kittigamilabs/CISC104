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

    public Rectangle(float newHeight, float newWidth)
    {
        // Should consider testing for positive numbers before accepting the parameters

        height = newHeight;
        width = newWidth;
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

