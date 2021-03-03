// Review and Refactor the following code. 
using System;

namespace SampleExercise
{
  public class Cube
  {
    public double Side { get; set; }
    public string Name = "Cube";

    public Cube(double side)
    {
      Side = side;
    }
  }

  public class Sphere
  {
    public double Radius { get; set; }
    public string Name = "Sphere";

    public Sphere(double radius)
    {
      Radius = radius;
    }
  }

  public class RectangularPyramid
  {
    public double Width { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }
    public string Name = "RectangularPyramid";

    public RectangularPyramid(double width, double length, double height)
    {
      Width = width;
      Length = length;
      Height = height;
    }
  }

  public class Calc
  {
    public double showV(object[] solids)
    {
      double volume = 0;
      foreach (var solid in solids)
      {
        if (solid.Name == "Cube")
        {
          Cube cube = (Cube)solid;
          volume += Math.Pow(cube.Side, 3);
        }
        else if (solid.Name == "Sphere")
        {
          Sphere sphere = (Sphere)solid;
          volume += 4 / 3 * Math.PI * Math.Pow(sphere.Radius, 3);
        }
        else if (solid.Name == "RectangularPyramid")
        {
          RectangularPyramid rectangularPyramid = (RectangularPyramid)solid;
          volume += 1 / 3 * rectangularPyramid.Width * rectangularPyramid.Length * rectangularPyramid.Height;
        }
      }
      return volume;
    }
  }
}
