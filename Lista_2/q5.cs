using System;
  class MainClass {
    public static void Main(string[] args) {
      Entrada e = new Entrada();
      Console.WriteLine("Digite o dia a ir no cinema:");
      e.SetDia(Console.ReadLine());
      Console.WriteLine("Digite o horário no formato hh:mm");
      string[] t = Console.ReadLine().Split(':');
      e.SetHora(int.Parse(t[0]));
      e.SetMinuto(int.Parse(t[1]));
      Console.WriteLine($"O valor da entrada é de R$ {e.entrada():0.00}");
    }
  }
  class Entrada {
    private string d;
    private int h, m;
    public void SetDia(string d) {
      if (d.Length > 0) { this.d = d; }
    }
    public void SetHora(int h) {
      if (h >= 0 && h < 24) { this.h = h; }
    }
    public void SetMinuto(int m) {
      if (m >= 0 && m < 60) { this.m = m; }
    }
    public string GetDia() {
      return d;
    }
    public int GetHora() {
      return h;
    }
    public int GetMinuto() {
      return m;
    }
    public double entrada() {
      double valor = 0;
      if (d == "Segunda" || d == "Terça" || d == "Quinta") {
        if (h < 17) { valor = 16; }
        if (h > 17) { valor = (16 * 0.5) + 16; }
      }
      if (d == "Quarta") {
        valor = 8;
      }
      if (d == "Sexta" || d == "Sábado" || d == "Domingo") { 
        if (h < 17) { valor = 20; }
        if (h > 17) { valor = (20 * 0.5) + 20; }
      }
      return valor;
    }
  }
  