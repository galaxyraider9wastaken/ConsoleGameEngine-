using System;

namespace ConsoleGameEngine {
  public class Matrix {
    public Vector2 Size;
    public float[][] M;
    public Matrix(Vector2 size){
      Size = size;
      M = new float[size.x][];
      for(int i=0;i<size.x;i++){
        M[i] = new float[size.y];
      }
    }
  }
}
