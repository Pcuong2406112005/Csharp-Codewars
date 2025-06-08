public class Kata
{
  public static string FakeBin(string x)
  {
    string s="";
    foreach(char c in x){
      if(c<'5') s=s+'0';
      else s=s+'1';
    }
    return s;
  }
}
