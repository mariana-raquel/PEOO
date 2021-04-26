using System;
  class MainClass {
   public static double Frete(double massa, double distancia) {
      double f = massa * distancia * 0.01;
      return f;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite a massa do seu frete:");
      double massa = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a distância do seu frete:");
      double distancia = double.Parse(Console.ReadLine());
     

      Console.WriteLine($"O preço do seu frete é {Frete(massa, distancia):0.00}");
    } 
  }