using System;
  class MainClass {
    public static void Intervalo(double x, out int inicio, out int fim) {
      inicio = (int) x;
      fim = inicio + 1;
    }
    public static void Main(string[] args){
      double x  = double.Parse(Console.ReadLine());
      Intervalo(x, out int y, out int z);
      Console.WriteLine(y);
      Console.WriteLine(z);
      Console.WriteLine($"[{y}, {z}]");
    }
  }