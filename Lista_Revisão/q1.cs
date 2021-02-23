using System;
  class MainClass {
    public static void Main (string[] args) {
      Esfera e = new Esfera();
      Console.WriteLine($"Digite o raio da sua esfera:");
      e.SetRaio(double.Parse(Console.ReadLine()));
      Console.WriteLine($"A área da sua esfera é {e.CalcArea():0.00}");
      Console.WriteLine($"O volume da sua esfera é {e.CalcVolume():0.00}");
    }
  }
  class Esfera {
    private double r;
    public void SetRaio(double r) {
      if (r > 0) { this.r = r; }
    }
    public double GetRaio() {
      return r;
    }
    public double CalcArea() {
      double a = 4 * 3.14159 * (r * r);
      return a;
    }
    public double CalcVolume() {
      double v = (4 * 3.14 * (r * r * r)) / 3;
      return v;
    }
  
  }