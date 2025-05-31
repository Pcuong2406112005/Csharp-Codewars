using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int result=0;
    foreach(var check in sheeps)
    {
      if(check==true) result+=1;
    }
    return result;
  }
}
