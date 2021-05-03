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
                if(Sprite.CSprite.M[i][i1] != Camera.WhiteSpaceChar){
                  Camera.Cam.M[(int)coords.X + i][(int)coords.Y + i1] = Sprite.CSprite.M[i][i1]; 
                  Camera.CCam.M[(int)coords.X + i][(int)coords.Y + i1] = Sprite.Colors.Colors.M[i][i1];
                }
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
      for(int i =0;i<(int)Camera.Size.X;i++){
        Console.WriteLine("");
        for(int i1 =0;i1<(int)Camera.Size.Y;i1++){
          switch(Camera.CCam.M[i][i1]){
            case "Black":
              Console.ForegroundColor = ConsoleColor.Black;
              break;
            case "DarkBlue":
              Console.ForegroundColor = ConsoleColor.DarkBlue;
              break;
            case "DarkGreen":
              Console.ForegroundColor = ConsoleColor.DarkGreen;
              break;
            case "DarkCyan":
              Console.ForegroundColor = ConsoleColor.DarkCyan;
              break;
            case "DarkRed":
              Console.ForegroundColor = ConsoleColor.DarkRed;
              break;
             case "DarkMagenta":
              Console.ForegroundColor = ConsoleColor.DarkMagenta;
              break;
            case "DarkYellow":
              Console.ForegroundColor = ConsoleColor.DarkYellow;
              break;
            case "Gray":
              Console.ForegroundColor = ConsoleColor.Gray;
              break;
            case "DarkGray":
              Console.ForegroundColor = ConsoleColor.DarkGray;
              break;
            case "Blue":
              Console.ForegroundColor = ConsoleColor.Blue;
              break;
            case "Green":
              Console.ForegroundColor = ConsoleColor.Green;
              break;
            case "Cyan":
              Console.ForegroundColor = ConsoleColor.Cyan;
              break;
            case "Red":
              Console.ForegroundColor = ConsoleColor.Red;
              break;
            case "Magenta":
              Console.ForegroundColor = ConsoleColor.Magenta;
              break;
            case "Yellow":
              Console.ForegroundColor = ConsoleColor.Yellow;
              break;
            case "White":
              Console.ForegroundColor = ConsoleColor.White;
              break;
          }
          Console.Write("" + Camera.Cam.M[i][i1]);
          Console.ForegroundColor = ConsoleColor.White;
        }
      }
    }
  }
}
