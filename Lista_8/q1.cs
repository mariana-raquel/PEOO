using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite o nome do estado:");
      string e = Console.ReadLine();
      Console.WriteLine("Digite o número de habitantes:");
      int h = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a área do estado em Km2:");
      double a = double.Parse(Console.ReadLine());

      double d = h / a;

      Console.WriteLine($"A densidade demográfica do {e} é de {d:0.0} hab/Km2");
      
    }
  }