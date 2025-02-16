using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadTreeApp.UnitTests.Models;
// RectangularPrism.cs
public class Rectangle
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public  double GetSurfaceArea()
    {
        return 2 * (Length * Width + Width * Height + Height * Length);
    }

    public  double GetVolume()
    {
        return Length * Width * Height;
    }

    public override bool Equals(object? obj)
    {
        return obj is Rectangle rectangle &&
               GetSurfaceArea() == rectangle.GetSurfaceArea();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(GetSurfaceArea());
    }
}
