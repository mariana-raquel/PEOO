using System;
  class MainClass {
    public static void Main(string[] args) {
      Velocidade v = new Velocidade();
      Console.WriteLine("Digite a distância percorrida em km:");
      v.SetDist(double.Parse(Console.ReadLine()));
      Console.WriteLine("Digite o tempo gasto no formato hh:mm");
      string[] thm = Console.ReadLine().Split(':');
      int h = int.Parse(thm[0]);
      int m = int.Parse(thm[1]);
      v.SetTempo(h + (m / 60.0));
      Console.WriteLine($"A velocidade média é de {v.velocidade():0.00} km/h");
    }
  }
  class Velocidade {
    private double dist, temp;
    public void SetDist(double d) {
      if (d > 0) { dist = d; }
    }
    public void SetTempo(double t) {
      if (t > 0) { temp = t; }
    }
    public double GetDist() {
      return dist;
    }
    public double GetTempo() {
      return temp;
    }
    public double velocidade() {
      double vm = dist / temp;
      return vm;
    }
  }