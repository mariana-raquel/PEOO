using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int c = int.Parse(e[0]);
      int q = int.Parse(e[1]);
      
      if (c == 1) {
        double v = q * 4.00;
        Console.WriteLine($"Total: R$ {v:0.00}");
      }
      if (c == 2) {
        double v = q * 4.50;
        Console.WriteLine($"Total: R$ {v:0.00}");
      }
      if (c == 3) {
        double v = q * 5.00;
        Console.WriteLine($"Total: R$ {v:0.00}");
      }
      if (c == 4) {
        double v = q * 2.00;
        Console.WriteLine($"Total: R$ {v:0.00}");
      }
      if (c == 5) {
        double v = q * 1.50;
        Console.WriteLine($"Total: R$ {v:0.00}");
      }
      
  }
}