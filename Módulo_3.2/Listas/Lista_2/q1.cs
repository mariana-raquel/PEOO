using System;
  class MainClass {
    public static void Main(string[] args) {
      Circulo c = new Circulo();
      Console.WriteLine("Digite o raio do seu círculo:");
      c.SetRaio(double.Parse(Console.ReadLine()));
      Console.WriteLine($"A área do seu círculo é {c.area():0.00}");
      Console.WriteLine($"A circunferência do seu círculo é {c.circ():0.00}");
    }
  }
  class Circulo {
    private double r;
    public void SetRaio(double v) {
      if (v > 0) { r = v; }
    }
    public double GetRaio() {
      return r;
    }
    public double area() {
      double area = 3.14159 * r * r;
      return area;
    }
    public double circ() {
      double circ = 2 * 3.14159 * r;
      return circ;
    }
  }
  
  /*run = "mcs -out:main.exe 'Lista_2/q2.cs' ; mono main.exe"*/