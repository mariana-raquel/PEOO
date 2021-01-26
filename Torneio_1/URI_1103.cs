using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      int c = int.Parse(e[2]);
      int d = int.Parse(e[3]);
      while (a != 0 || b != 0 || c != 0 || d != 0) {
        
        int mi = (a * 3600) + (b*60);
        int mf = (c * 3600) + (d*60);
        int t = (mf - mi) / 60;

        Console.WriteLine(t);

        e = Console.ReadLine().Split(' ');
        a = int.Parse(e[0]);
        b = int.Parse(e[1]);
        c = int.Parse(e[2]);
        d = int.Parse(e[3]);
      }
  }
}