using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      double a = double.Parse(e[0]);
      double b = double.Parse(e[1]);
      double c = double.Parse(e[2]);
      const double pi = 3.14159;

      double triangulo = (a * c) / 2;
      double circulo = pi * (c * c);
      double trapezio = ((a + b) * c) / 2;
      double quadrado = b * b;
      double retangulo = a * b;

      Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
      Console.WriteLine($"CIRCULO: {circulo:0.000}");
      Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
      Console.WriteLine($"QUADRADO: {quadrado:0.000}");
      Console.WriteLine($"RETANGULO: {retangulo:0.000}");
  }
}
