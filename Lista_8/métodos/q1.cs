using System;
  class MainClass {
   public static double AreaCirculo(double raio) {
      double r = 3.14 * (raio * raio);
      return r;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite o raio do círculo:");
      double raio = double.Parse(Console.ReadLine());
      Console.WriteLine($"A área do seu círculo é {AreaCirculo(raio):0.0}");
    } 
  }