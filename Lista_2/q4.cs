using System;
  class MainClass {
    public static void Main(string[] args) {
      Conta cn = new Conta();
      Console.WriteLine("Informe seu nome:");
      cn.SetTitular(Console.ReadLine());
      Console.WriteLine("Informe o número da sua conta:");
      cn.SetConta(double.Parse(Console.ReadLine()));
      Console.WriteLine("Informe o saldo da sua conta:");
      cn.SetSaldo(double.Parse(Console.ReadLine()));
      Console.WriteLine("Informe a transação a ser realizada:");
      cn.SetTransação(Console.ReadLine());
      Console.WriteLine("Informe o valor da transação:");
      cn.SetValor(double.Parse(Console.ReadLine()));
      
      Console.WriteLine($"Olá {cn.GetTitular()}, conta nº: {cn.GetConta()}, foi efetuado uma transação de {cn.GetTransação()} no valor de R$ {cn.GetValor():0.00} na sua conta, que agora está com o valor de R$ {cn.NovoSaldo():0.00}");
    }
  }
  class Conta {
    private string tit, t;
    private double c, vt, s ;
    public void SetTitular(string a) {
      tit = a;
    }
    public void SetTransação(string a) {
      t = a;
    }
    public void SetConta(double a) {
      c = a;
    }
    public void SetValor(double a) {
      vt = a;
    }
    public void SetSaldo(double a) {
      s = a;
    }

    public string GetTitular() {
      return tit;
    }
    public string GetTransação() {
      return t;
    }
    public double GetConta() {
      return c;
    }
    public double GetValor() {
      return vt;
    }
    public double GetSaldo() {
      return s;
    }
    public double NovoSaldo() {
      double saldo = 0;
      if (t == "Débito" || t == "Debito" || t == "débito" || t == "debito") {
        saldo = s - vt;
        return saldo;
      }
      if (t == "Crédito" || t == "Credito" || t == "crédito" || t == "credito") {
        saldo = s + vt;
      }
      return saldo;
    }
  }