using System;

public class Kata
{
    public static string Remove_char(string s)
    {
      string result="";
      for(int i=0;i<s.Length;i++)
      {
        if(i==0||i==s.Length-1) continue;
        result+=s[i];
      }
        return result; // Your Code
    }
}
