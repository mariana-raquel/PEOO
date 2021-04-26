using System;
  class MainClass {
   public static double VolumeLitros(double h, double l, double p) {
      double v = h * l * p;
      return v;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite a altura da sua caixa d'água:");
      double h = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a largura da sua caixa d'água:");
      double l = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a base da sua caixa d'água:");
      double p = double.Parse(Console.ReadLine());

      Console.WriteLine($"O volume da sua caixa d'água é {VolumeLitros(h, l, p):0.00}");
    } 
  }