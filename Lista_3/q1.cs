using System; 
  class MainClass {
    public static void Main (string[] args) {
      Retangulo r = new Retangulo(0, 0);
      Console.WriteLine("Qual a base do retângulo?");
      r.SetBase(int.Parse(Console.ReadLine()));
      Console.WriteLine("Qual a altura do retângulo?");
      r.SetAltura(int.Parse(Console.ReadLine()));
      Console.WriteLine($"A área do retângulo é {r.CalcArea():0.00}");
      Console.WriteLine($"A Diagonal do retângulo é {r.CalcDiagonal():0.00}");
      Console.WriteLine(r.ToString());
    }
  }
  class Retangulo {
    private double b, h;
    public Retangulo (double b, double h) {
      if (b >= 0) { this.b = b; }
      if (h >= 0) { this.h = h; }
    }
    public void SetBase(double b) {
      if (b >= 0) { this.b = b; }
    }
    public void SetAltura(double h) {
      if (h >= 0) { this.h = h; }
    }
    public double GetBase() {
      return b;
    }
    public double GetAltura() {
      return h;
    }
    public double CalcArea() {
      double a = b * h;
      return a;
    }
    public double CalcDiagonal() {
      double d = Math.Sqrt((b * b) + (h * h));
      return d;
    }
    public override string ToString(){
      return $"Base = {b}, Altura = {h}";
    }




  }