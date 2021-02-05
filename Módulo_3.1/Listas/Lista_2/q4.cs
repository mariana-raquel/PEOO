using System;
  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine("Digite a base e a altura do retângulo:");
      double b = double.Parse(Console.ReadLine());
      double h = double.Parse(Console.ReadLine());

      double a = b * h;
      double p = (b * 2) + (h * 2);
      double d = Math.Sqrt((b * b) + (h * h));

      Console.WriteLine($"Área = {a:0.00} - Perímetro = {p:0.00} - Diagonal = {d:0.00}");   
  }
}
