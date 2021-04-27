using System;

namespace ConsoleGameEngine{
  public class Sprite{
    public Vector2 Size;
    public string File;
    public Matrix CSprite;
    public Sprite(Vector2 size, string file){
      Size = size;
      File = file;
      CSprite = new string[Size.x][];
      for(int i=0;i<size.x;i++){
        CSprite[i] = new string[Size.y];
      }
    }
  }
}
