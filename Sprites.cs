using System;
using System.IO;

namespace ConsoleGameEngine{
  public class Sprite{
    public Vector2 Size;
    public string File;
    public Matrix CSprite;
    public Sprite(Vector2 size, string file){
      Size = size;
      File = file;
      CSprite = new string[Size.X][];
      for(int i=0;i<size.X;i++){
        CSprite[i] = new string[Size.Y];
      }
      var fx = File.ReadAllLines(file);
      var fx = new string[Size.Y][];
      for(int i =0;i<Size.Y;i++{
        fy[i] = fx[i].split();
      }
      CSprite = fy;
    }
  }
}
