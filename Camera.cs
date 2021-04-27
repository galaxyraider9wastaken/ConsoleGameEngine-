using System;

namespace ConsoleGameEngine {
  public class Camera {
    public Vector2 Coordinates;
    public Vector2 Size;
    public Matrix Cam;
    public Camera(Vector2 coordinates, Vector2 size) {
      Coordinates = coordinates;
      Size = size;
      Cam = new Matrix(Size);
    }
  }
}
