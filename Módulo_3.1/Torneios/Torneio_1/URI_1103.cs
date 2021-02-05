using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      int c = int.Parse(e[2]);
      int d = int.Parse(e[3]);
      while (a != 0 || b != 0 || c != 0 || d != 0) {
        if (c < a || c == a && d < b) {
          int mi = 1440 -((a * 60) + b);
          int mf = ((c * 60) + d);
          int t = mf + mi;
          Console.WriteLine(t);
        }
        else {
          int mi = ((a * 60) + b);
          int mf = ((c * 60) + d);
          int t = mf - mi;
          Console.WriteLine(t);
        }
        
        e = Console.ReadLine().Split(' ');
        a = int.Parse(e[0]);
        b = int.Parse(e[1]);
        c = int.Parse(e[2]);
        d = int.Parse(e[3]);
      }
  }
}