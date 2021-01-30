using System;
  class MainClass {
    public static void Main(string[] args) {
      int e = int.Parse(Console.ReadLine());
      int a = 0;
      int b = 1;
      int aux;
      int i = 0;
      Console.Write($"{a} {b}");
      while (i < e-2) {
          aux = a;
          a = b;
          b = aux + b;
          Console.Write($" {b}");
          i++;
        }
        Console.WriteLine();
    }
  }