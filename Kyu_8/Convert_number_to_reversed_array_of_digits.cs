using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      if(n==0) return new long[] {0};
      List<long> digits= new List<long> ();
      foreach(char c in n.ToString()){
        digits.Insert(0,c-'0');
      }
      return digits.ToArray();
    }
  }
}
