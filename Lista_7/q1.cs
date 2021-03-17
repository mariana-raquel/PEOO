using System;
  class MainClass {
    public static void Main(string[] args) {
      Retangulo r = new Retangulo();
      Console.WriteLine("Qual é a base do seu retângulo?");
      r.Base = double.Parse(Console.ReadLine());
      Console.WriteLine("Qual é a altura do seu retângulo?");
      r.Altura = double.Parse(Console.ReadLine());
      Console.WriteLine(r);
      Console.WriteLine($"A área do seu retângulo é {r.Area:0.00} e a diagonal é {r.Diagonal:0.00}");
    }
  }
  class Retangulo {
    private double b, h;
    public double Base {
      get { return b; }
      set { if (value > 0) b = value; }
    }
    public double Altura {
      get { return h; }
      set { if (value > 0) h = value; }
    }
    public double Area {
      get { return b * h; }
    }
    public double Diagonal {
      get { return Math.Sqrt((b * b) + (h * h)); }
    }
    public override string ToString() {
      return $"Base = {b} - Altura = {h}";
    }
  }