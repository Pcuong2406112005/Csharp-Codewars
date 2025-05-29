using System;
using System.Collections.Generic;

public static class Kata
{
  public static string CannonsReady(Dictionary<string, string> gunners)
  {
    foreach (var response in gunners.Values)
    {
      if (response != "aye")
      {
        return "Shiver me timbers!";
      }
    }
    return "Fire!";
  }
