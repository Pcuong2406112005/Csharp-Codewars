using System;

public class Ball {
  public string ballType { get; set; }
  
  public Ball() : this ("regular") {}
  
  public Ball(string ballType) {
    this.ballType = ballType ?? "regular";
  }
}
