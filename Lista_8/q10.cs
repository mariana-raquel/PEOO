using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a cidade de origem:");
      string co = Console.ReadLine();
      Console.WriteLine("Digite a cidade de destino");
      string cd = Console.ReadLine();
      Console.WriteLine("Digite a distância percorrida em quilômetros:");
      double dp = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a velocidade média em km/h:");
      double vm = double.Parse(Console.ReadLine());

      double t = dp / vm;
      int h = (int)t;
      double m = (t - h) * 60;

      Console.WriteLine($"O tempo estimado de viagem entre {co} e {cd} é de {h} horas e {m} minutos.");


      
    }
  }
