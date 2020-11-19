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
  public double Volume(object[] solids)
  {
    double volume = 0;
    foreach (var solid in solids)
    {
      if (solid is Cube)
      {
        Cube cube = (Cube)solid;
        volume += Math.Pow(cube.side, 3);
      }
      else if (solid is Sphere)
      {
        Sphere sphere = (Sphere)solid;
        volume += 4/3 * Math.PI * Math.Pow(sphere.Radius, 3);
      }
      else if (solid is RectangularPyramid)
      {
        RectangularPyramid rectangularPyramid = (RectangularPyramid)solid;
        volume += 1/3 * rectangularPyramid.Width * rectangularPyramid.Length * rectangularPyramid.Height;
      }
    }

    return volume;
  }
}