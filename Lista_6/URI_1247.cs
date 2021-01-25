using System;
  class MainClass {
    public static void Main (string[] args) {

      string [] e = Console.ReadLine().Split(' ');
      int d = int.Parse(e[0]);
      int vf = int.Parse(e[1]);
      int vg = int.Parse(e[2]);
      int dg = d * vg;
      int df = d * vf;
      if (dg > df) { Console.WriteLine("S"); }
      if (dg < df) { Console.WriteLine("N"); }
  }
}