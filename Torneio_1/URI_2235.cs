using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] x = Console.ReadLine().Split(' ');
      int a = int.Parse(x[0]);
      int b = int.Parse(x[1]);
      int c = int.Parse(x[2]);
      int y = 0;
      if (a + b + c != y) { Console.WriteLine("N"); }
      if (a + b - c != y) { Console.WriteLine("N"); }
      if (a - b - c != y) { Console.WriteLine("N"); }
      if (a - b + c != y) { Console.WriteLine("N"); }

      if (a + b + c == y) { Console.WriteLine("Y"); }
      if (a + b - c == y) { Console.WriteLine("Y"); }
      if (a - b - c == y) { Console.WriteLine("Y"); }
      if (a - b + c == y) { Console.WriteLine("Y"); }
  }
}