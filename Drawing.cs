using System;

namespace ConsoleGameEngine{
  public class Drawing{
    public static Camera DrawSprite(Vector2 DCoordinates, Sprite Sprite, Camera Camera){
      var Iv = 0;
      var coords = new Vector2(Camera.Coordinates.X - DCoordinates.X, Camera.Coordinates.Y - DCoordinates.Y);
      if(Iv == 0){
        for(int i =0;i<Sprite.Size.X;i++){
          if(coords.X + i <= Camera.Cam.M.Length && coords.X + i >= 0){
            for(int i1 =0;i1<Sprite.Size.Y;i1++){
              if(coords.Y + i1 <= Camera.Cam.M[i].Length && coords.Y + i1 >= 0){
                Camera.Cam.M[(int)coords.X + i][(int)coords.Y + i1] = Sprite.CSprite.M[i][i1]; 
              }
            }
          }
        }
      }
      return Camera;
    }
    public static void Draw(Camera Camera){
      Console.SetCursorPosition(1,0);
      Console.WriteLine("\n");
      for(int i = 0;i<(int)Camera.Size.X;i++){
        Console.WriteLine(string.Join("", Camera.Cam.M[i]));
      }
    }
  }
}
