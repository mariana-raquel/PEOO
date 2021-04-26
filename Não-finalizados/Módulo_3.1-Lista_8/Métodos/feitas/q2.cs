using System;
  class MainClass {
  public static double Diagonal(double b, double h) {
      double d = Math.Sqrt((b * b) + (h * h));
      return d;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite a base do retângulo:");
      double b = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a altura do triângulo:");
      double h = double.Parse(Console.ReadLine());
      Console.WriteLine($"A diagonal do seu retângulo é {Diagonal(b, h):0.0}");
    } 
  }