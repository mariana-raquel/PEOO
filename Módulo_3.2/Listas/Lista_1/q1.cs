using System;
  class MainClass {
    public static void Main(string[] args) {
      Circulo c = new Circulo();
      Console.WriteLine("Digite o raio do seu círculo:");
      c.r = double.Parse(Console.ReadLine());
      Console.WriteLine(c.area());
    }
  }
  class Circulo {
    public double r;
    public double area() {
      double area = 3.14159 * r * r;
      return area;
    }
  }
  