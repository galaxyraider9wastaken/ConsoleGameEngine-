using System;

namespace ConsoleGameEngine {
  public class Camera {
    public Vector2 Coordinates;
    public Vector2 Size;
    public Matrix Cam;
    public Matrix CCam;
    public string FillInChar = "=";
    public string WhiteSpaceChar = "~";
    public Camera(Vector2 coordinates, Vector2 size) {
      Coordinates = coordinates;
      Size = size;
      Cam = new Matrix(Size);
      CCam = new Matrix(Size);
      Clear();
    }
    public void Clear(){
      for(int i =0;i<Size.X;i++){
        for(int i1 =0;i1<Size.Y;i1++){
          Cam.M[i][i1] = FillInChar;
          CCam.M[i][i1] = "White";
        }
      }
    }
  }
}
