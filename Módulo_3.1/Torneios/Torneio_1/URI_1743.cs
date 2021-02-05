using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] x = Console.ReadLine().Split(' ');
      int a = int.Parse(x[0]);
      int b = int.Parse(x[1]);
      int c = int.Parse(x[2]);
      int d = int.Parse(x[3]);
      int e = int.Parse(x[4]);
      
      string[] x1 = Console.ReadLine().Split(' ');
      int a1 = int.Parse(x1[0]);
      int b1 = int.Parse(x1[1]);
      int c1 = int.Parse(x1[2]);
      int d1 = int.Parse(x1[3]);
      int e1 = int.Parse(x1[4]);
      int z = 0;

      if (a == a1) {z += 1; }
      if (b == b1) {z += 1; }
      if (c == c1) {z += 1; }
      if (d == d1) {z += 1; }
      if (e == e1) {z += 1; }

      if (z == 0) { Console.WriteLine("Y"); }
      if (z != 0) { Console.WriteLine("N"); }
  }
}