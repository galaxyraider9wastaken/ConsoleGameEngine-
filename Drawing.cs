using System;

namespace ConsoleGameEngine{
  public class Drawing{
    public static Camera DrawSprite(Vector2 DCoordinates, Sprite Sprite, Camera Camera){
      var coords = new Vector2(Camera.Coordinates.X - DCoordinates.X, Camera.Coordinates.Y - DCoordinates.Y);
      for(int i =0;i<Sprite.Size.X;i++){
        for(int i1 =0;i1<Sprite.Size.Y;i1++){
          Camera.Cam.M[(int)coords.X + i][(int)coords.Y + i1] = Sprite.CSprite.M[i][i1];
        }
      }
      return Camera;
    }
    public static void Draw(Camera Camera){
      for(int i = 0;i<(int)Camera.Size.X;i++){
        Console.WriteLine(string.Join("", Camera.Cam.M[i]));
      }
    }
  }
}
