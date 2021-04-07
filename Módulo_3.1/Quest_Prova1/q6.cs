using System;
  class MainClass {
    public static int Maior(int a, int b, int c, int d) {
      int m = Math.Max(Math.Max(Math.Max(c, d), b), a);
      return m;
    }
    public static void Main(string[] args) {
        string numero = Console.ReadLine();
        while (numero != "0") {
          int a = int.Parse(numero.Substring(0,1));
          int b = int.Parse(numero.Substring(1,1));
          int c = int.Parse(numero.Substring(2,1));
          int d = int.Parse(numero.Substring(3,1));
        
          Console.WriteLine($"Maior Algarismo = {Maior(a, b, c, d)}");
          numero = Console.ReadLine();
      }
    }
  }