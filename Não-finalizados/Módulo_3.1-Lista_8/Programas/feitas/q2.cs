using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite o valor gasto com o combustível em reais:");
      double vg = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor do litro do combustível em reais:");
      double vl = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a distância percorrida em quilômetros");
      double d = double.Parse(Console.ReadLine());

      double l = vg / vl;
      double cm = d / l;
      double gkm = vl / cm;

      Console.WriteLine($"O consumo médio é de {cm:0.00} Km por litro");
      Console.WriteLine($"O gasto por Km percorrido é R$ {gkm:0.00}"); 
    }
  }