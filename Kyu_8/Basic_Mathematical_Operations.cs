namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
      if(operation=='+') return value1+value2;
      if(operation=='-') return value1-value2;
      if(operation=='*') return value1*value2;
      if(operation=='/') return value1/value2;
      return -1;
    }
  }
}
