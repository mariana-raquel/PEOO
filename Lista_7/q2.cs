using System;
  class MainClass {
    public static void Main(string[] args) {
      Frete f = new Frete();
      Console.WriteLine("Qual a distância do seu frete?");
      f.Distancia = double.Parse(Console.ReadLine());
      Console.WriteLine("Quantos Kg você deseja transportar?");
      f.Peso = double.Parse(Console.ReadLine());
      Console.WriteLine(f);
      Console.WriteLine($"O valor do frete é R${f.ValorFrete:0.00}");
    }
  }
  class Frete {
    private double d, p;
    public double Distancia {
      get { return d; }
      set { if (value > 0) d = value; }
    }
    public double Peso {
      get { return p; }
      set { if (value > 0) p = value; }
    }
    public double ValorFrete {
      get { return p * d * 0.01; }
    }
    public override string ToString() {
      return $"Distância = {d} - Peso = {p}";
    }
  }