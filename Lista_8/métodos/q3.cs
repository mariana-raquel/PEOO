using System;
  class MainClass {
  public static double VolumeEsfera(double r) {
      double v = (4 * 3.14 * r * r * r) / 3;
      return v;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite o raio do seu círculo:");
      double r = double.Parse(Console.ReadLine());
      Console.WriteLine($"O volume do seu círculo é {VolumeEsfera(r):0.0}");
    } 
  }