// Review and Refactor the following code. 
public class Rectangle
{
  public double Width { get; set; }
  public double Height { get; set; }
}

public class Circle
{
  public double Radius { get; set; }
}

public class Triangle
{
  public double Base { get; set; }
  public double Height { get; set; }
}

public class ShapesAreaCalculator
{
  public double Area(object[] shapes)
  {
    double area = 0;
    foreach (var shape in shapes)
    {
      if (shape is Rectangle)
      {
        Rectangle rectangle = (Rectangle)shape;
        area += rectangle.Width * rectangle.Height;
      }
      else if (shape is Circle)
      {
        Circle circle = (Circle)shape;
        area += circle.Radius * circle.Radius * Math.PI;
      }
      else if (shape is Triangle)
      {
        Triangle triangle = (Triangle)shape;
        area += .5 * triangle.Base * triangle.Height;
      }
    }

    return area;
  }
}