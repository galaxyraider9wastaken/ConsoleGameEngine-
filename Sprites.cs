using System;
using System.IO;

namespace ConsoleGameEngine{
  public class Sprite{
    public Vector2 Size;
    public string SFile;
    public Matrix CSprite;
    public Sprite(Vector2 size, string file){
      Size = size;
      SFile = file;
      CSprite = new Matrix(Size);
      var fx = File.ReadAllLines(file);
      for(int i =0;i<(int)Size.X;i++){
        CSprite.M[i] = fx[i].Split();
      }
    }
  }
}
