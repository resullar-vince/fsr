// Review, Comment and/or Refactor the following code. 
class Cube
{
  constructor(side) {
    this.side = side;
    this.name = "Cube";
  }
}

class Sphere
{
  constructor(radius) {
    this.radius = radius;
    this.name = "Sphere";
  }
}

class RectangularPyramid
{
  constructor(width, length, height) {
    this.width = width;
    this.length = length;
    this.height = height;
    this.name = "Rectangular Pyramid";
  }
}

function ShowV(solids) {
  solids.forEach(solid => {
    if(solid.name === "Cube") {
      const volume = Math.pow(solid.side, 3);
      console.log(solid.name + " volume: " + volume);
    } else if(solid.name === "Sphere") {
      const volume = 4/3 * Math.PI * Math.Pow(solid.Radius, 3);
      console.log(solid.name + " volume: " + volume);
    } else if(solid.name === "Rectangular Pyramid") {
      const volume = 1/3 * solid.width * solid.length * solid.height;
      console.log(solid.name + " volume: " + volume);
    }
  })
}

const solids = [new Cube(4), new Sphere(3), new RectangularPyramid(3, 4, 6)];

ShowV(solids);
