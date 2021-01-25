using System;
  class MainClass {
    public static void Main (string[] args) {
      int c = 0;
      double s = 0;
      while (c < 2) {
        double a = double.Parse(Console.ReadLine());
        if (a > 0 && a <= 10) {
          s = s + a;
          c = c + 1;
        }
        if (a < 0 || a > 10) {
          Console.WriteLine("nota invalida");
        } 
      }
      double m = s / 2;
      Console.WriteLine($"media = {m:0.00}");
  }
}
