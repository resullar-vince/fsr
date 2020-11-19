// Review and Refactor the following code. 
public class Cube
{
  public double Side { get; set; }
}

public class Sphere
{
  public double Radius { get; set; }
}

public class RectangularPyramid
{
  public double Width { get; set; }
  public double Length { get; set; }
  public double Height { get; set; }
}

public class VolumeCalculator
{
  public double Volume(object[] shapes)
  {
    double volume = 0;
    foreach (var shape in shapes)
    {
      if (shape is Cube)
      {
        Cube cube = (Cube)shape;
        volume += Math.Pow(cube.side, 3);
      }
      else if (shape is Sphere)
      {
        Sphere sphere = (Sphere)shape;
        volume += 4/3 * Math.PI * Math.Pow(sphere.Radius, 3);
      }
      else if (shape is RectangularPyramid)
      {
        RectangularPyramid rectangularPyramid = (RectangularPyramid)shape;
        volume += 1/3 * rectangularPyramid.Width * rectangularPyramid.Length * rectangularPyramid.Height;
      }
    }

    return volume;
  }
}