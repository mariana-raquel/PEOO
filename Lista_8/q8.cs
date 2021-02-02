using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite três valores reais separados por ponto e vírgulas:");
      string[] e = Console.ReadLine().Split(';');
      double a = double.Parse(e[0]);
      double b = double.Parse(e[1]);
      double c = double.Parse(e[2]);

      double s = a + b + c;

      Console.WriteLine($"Soma = {s:0.00}");
    }
  }