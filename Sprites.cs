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
      var fx = File.ReadAllLines(file);
      var fy = new string[(int)Size.Y][];
      var fym = new Matrix(Size);
      for(int i =0;i<(int)Size.Y;i++){
        fy[i] = fx[i].Split();
      }
      fym.M = fy;
      CSprite = fym;
    }
  }
}
