using System;
  class MainClass {
    public static void Main(string[] args) {
      Conta cn = new Conta();
      Console.WriteLine("Informe seu nome:");
      cn.tit = Console.ReadLine();
      Console.WriteLine("Informe o número da sua conta:");
      cn.c = double.Parse(Console.ReadLine());
      Console.WriteLine("Informe o saldo da sua conta:");
      cn.s = double.Parse(Console.ReadLine());
      Console.WriteLine("Informe a transação a ser realizada:");
      cn.t = Console.ReadLine();
      Console.WriteLine("Informe o valor da transação:");
      cn.vt = double.Parse(Console.ReadLine());
      
      Console.WriteLine($"Olá {cn.tit}, conta nº: {cn.c}, foi efetuado uma transação de {cn.t} no valor de R$ {cn.vt:0.00} na sua conta, que agora está com o valor de R$ {cn.conta():0.00}");
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
    
    public double conta() {
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