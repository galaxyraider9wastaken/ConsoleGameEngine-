using System;
using System.IO;

namespace ConsoleGameEngine{
  public class Sprite{
    public Vector2 Size;
    public string SFile;
    public Matrix CSprite;
    public SpriteColor Colors;
    public Sprite(Vector2 size, string file, SpriteColor colors){
      Size = size;
      SFile = file;
      CSprite = new Matrix(Size);
      Colors = colors;
      var fx = File.ReadAllLines(file);
      var fc = new char[(int)Size.X][];
      for(int i =0;i<(int)Size.X;i++){
        fc[i] = new char[(int)Size.Y];
      }
      for(int i =0;i<(int)Size.X;i++){
        fc[i] = fx[i].ToCharArray();
      }
      for(int i =0;i<(int)Size.X;i++){
        for(int i1 =0;i1<(int)Size.Y;i1++){
          CSprite.M[i][i1] = fc[i][i1].ToString();
        }
      }
    }
  }
}
