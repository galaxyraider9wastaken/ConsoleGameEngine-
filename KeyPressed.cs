using System;

namespace ConsoleGameEngine{
  public class KeyBoard{
    public ConsoleKeyInfo key_pressed = new ConsoleKeyInfo();
    public KeyBoard(){

    }
    public bool Pressed(char Key){
      if(Console.KeyAvailable)
      {
        key_pressed = Console.ReadKey();
      }
      if(key_pressed.KeyChar == Key){
        return true;
      } else {
        return false;
      }
    }
  }
}
