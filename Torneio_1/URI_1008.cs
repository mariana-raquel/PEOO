using System;
  class MainClass {
    public static void Main (string[] args) {
      int n = int.Parse(Console.ReadLine());
      int h = int.Parse(Console.ReadLine());
      double v = double.Parse(Console.ReadLine());
      double s = h * v;
        Console.WriteLine($"NUMBER = {n}");
        Console.WriteLine($"SALARY = U$ {s:0.00}");
  }
}