# Task:
# - Create a feature that can display and calculate volumes of 3D shapes (cube, sphere, etc.)
# 
# As a Final Reviewer, you should be able to:
# Comment, review and/or refactor the code below.
import math

class Cube:
    def __init__(self, side):
        self.side = side
        self.name = "Cube"

class Sphere:
    def __init__(self, radius):
        self.radius = radius
        self.name = "Sphere"

class RectangularPyramid:
    def __init__(self, width, length, height):
        self.width = width
        self.length = length
        self.height = height
        self.name = "Rectangular Pyramid"

def ShowV(solids):
    for solid in solids:
        if (solid.name == "Cube"):
            volume = solid.side ** 3
            print(solid.name, "volume:", volume)
        elif (solid.name == "Sphere"):
            volume = (4 / 3) * math.pi * (solid.radius ** 3)
            print(solid.name, "volume:", volume)
        elif (solid.name == "Rectangular Pyramid"):
            volume = (1 / 3) * solid.width * solid.length * solid.height
            print(solid.name, "volume:", volume)

if __name__ == "__main__":
    solids = [Cube(4), Sphere(3), RectangularPyramid(3, 4, 6)]
    ShowV(solids)
