using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a distância percorrida em km e o tempo gasto no formato hh:mm");
      string[] dt = Console.ReadLine().Split(' ');
      int dist = int.Parse(dt[0]);
      string[] thm = dt[1].Split(':');
      int h = int.Parse(thm[0]);
      int m = int.Parse(thm[1]);
      Viagem v = new Viagem(dist, (h + (m / 60.0)));
      v.SetDist(dist);
      v.SetTempo(h + (m / 60.0));
      Console.WriteLine(v);
    }
  }
  class Viagem {
    private double d, t;
    public Viagem(double vd, double vt) {
      if (vd > 0) vd = d;
      if (vt > 0) vt = t;
    }
    public void SetDist (double d) {
     if (d > 0) { this.d = d; }
    }
    public void SetTempo (double t) {
     if (t > 0) { this.t = t; }
    }
    public double GetDist () {
     return d;
    }
    public double GetTempo () {
     return t;
    }
    public double CalcVelocidade () {
     double v = d / t;
     return v;
    }
    public override string ToString() {
      return $"A velocidade média é de {CalcVelocidade()} km/h";
    }
  }