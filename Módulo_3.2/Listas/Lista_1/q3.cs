using System;
  class MainClass {
    public static void Main(string[] args) {
      Velocidade v = new Velocidade();
      Console.WriteLine("Digite a distância percorrida em km:");
      v.d = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o tempo gasto no formato hh:mm");
      string[] t = Console.ReadLine().Split(':');
      v.h = int.Parse(t[0]);
      v.m = int.Parse(t[1]);
      Console.WriteLine($"A velocidade média é de {v.velocidade()} km/h");
    }
  }
  class Velocidade {
    public double d;
    public int h, m;
    public double velocidade() {
      double vm = d / (h + (m/60));
      return vm;
    }
  }
  