using System; 
  class MainClass {
    public static void Main (string[] args) {
      Frete f = new Frete(0, 0);
      Console.WriteLine("Qual a distância percorrida (em km)?");
      f.SetDistancia(int.Parse(Console.ReadLine()));
      Console.WriteLine("Qual o peso da carga (em kg)?");
      f.SetPeso(int.Parse(Console.ReadLine()));
      Console.WriteLine($"O frete é R${f.CalcFrete():0.00}");
      Console.WriteLine(f.ToString());
    }
  }
  class Frete {
    private double d, p;
    public Frete (double d, double p) {
      if (d >= 0) { this.d = d; }
      if (p >= 0) { this.p = p; }
    }
    public void SetDistancia(double d) {
      if (d >= 0) { this.d = d; }
    }
    public void SetPeso(double p) {
      if (p >= 0) { this.p = p; }
    }
    public double GetDistancia() {
      return d;
    }
    public double GetPeso() {
      return p;
    }
    public double CalcFrete() {
      double f = (p / d) * 0.01;
      return f;
    }
    public override string ToString(){
      return $"Peso = {p}, Distância = {d}";
    }




  }