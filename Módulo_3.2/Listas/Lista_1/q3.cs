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
      Console.WriteLine($"A velocidade média é de {v.VelMed():0.00} km/h");
    }
  }
  class Velocidade {
    public double d;
    public int h, m;
    public double VelMed() {
      double temp = h + ((double) m/60);
      double vm = d / temp;
      return vm;
    }
  }
  