using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RectangleTests
{
    // Test the default constructor
    [Test]
    public void RectangleDefaultConstructorTest()
    {
        // Setup and Act
        Rectangle defaultRectangle = new Rectangle();

        // Assert
        Assert.AreEqual(0, defaultRectangle.GetHeight());
        Assert.AreEqual(0, defaultRectangle.GetWidth());
        Assert.AreEqual(0, defaultRectangle.GetPerimeter());
        Assert.AreEqual(0, defaultRectangle.GetArea());
    }

    // Test a 2 x 4 Rectangle
    [Test]
    public void RectangleTwoByFourTest()
    {
        // Setup and Act
        Rectangle twoByFour = new Rectangle(2f, 4f);

        // Assert
        Assert.AreEqual(2, twoByFour.GetHeight());
        Assert.AreEqual(4, twoByFour.GetWidth());
        Assert.AreEqual(12, twoByFour.GetPerimeter());
        Assert.AreEqual(8, twoByFour.GetArea());
    }

    // Test a 10 x 10 Rectangle
    [Test]
    public void RectangleTenByTenTest()
    {
        // Setup and Act
        Rectangle tenByTen = new Rectangle(10f, 10f);

        // Assert
        Assert.AreEqual(10, tenByTen.GetHeight());
        Assert.AreEqual(10, tenByTen.GetWidth());
        Assert.AreEqual(40, tenByTen.GetPerimeter());
        Assert.AreEqual(100, tenByTen.GetArea());
    }

    // Test the SetHeight method
    [Test]
    public void RectangleSetHeightTest()
    {
        // Setup
        Rectangle someRectangle = new Rectangle(1, 5);

        // Act
        someRectangle.SetHeight(100);

        // Assert
        Assert.AreNotEqual(1, someRectangle.GetHeight());  // This assertion is redundant, but an example
        Assert.AreEqual(100, someRectangle.GetHeight());

        Assert.AreEqual(5, someRectangle.GetWidth());
        Assert.AreEqual(210, someRectangle.GetPerimeter());
        Assert.AreEqual(500, someRectangle.GetArea());
    }
}
