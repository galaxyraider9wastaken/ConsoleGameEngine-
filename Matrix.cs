using System;

namespace ConsoleGameEngine {
  public class Matrix {
    public Vector2 Size;
    public string[][] M;
    public Matrix(Vector2 size){
      Size = size;
      M = new string[(int)size.X][];
      for(int i=0;i<(int)size.X;i++){
        M[i] = new string[(int)size.Y];
      }
    }
  }
}
