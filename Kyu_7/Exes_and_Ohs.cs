using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    int countx=0;int counto=0;
    foreach(char c in input){
      if(c=='x'||c=='X') countx=countx+1;
      if(c=='o'||c=='O') counto=counto+1;
    }
    return countx==counto;
  }
}
