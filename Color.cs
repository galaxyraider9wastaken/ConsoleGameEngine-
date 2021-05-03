using System;
using System.IO;

namespace ConsoleGameEngine{
  public class SpriteColor{
    public Vector2 Size;
    public string RFile;
    public Matrix Colors;
    public SpriteColor(Vector2 size, string file){
      Size = size;
      RFile = file;
      var c = File.ReadAllLines(file);
      Colors = new Matrix(Size);
      for(int i =0;i<(int)Size.X;i++){
          Colors.M[i] = c[i].Split(",");
      }
    }
  }
}
