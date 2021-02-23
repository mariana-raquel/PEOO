using System;
  class MainClass {
    public static void Main(string[] args) {
      Fibonacci f = new Fibonacci();
      Console.WriteLine("Digite quantos números você deseja na sua sequência de Fibonacci:");
      f.p(int.Parse(Console.ReadLine()));
      Console.WriteLine($"Sua sequência é {f.Proximo()}");
    }
  }
  class Fibonacci {
    public int p;
    public void Iniciar() {
      int a = 0;
      int b = 1;
    }
    public int Proximo() {
      return $"{Iniciar(a)}, {Iniciar(b)}, {Iniciar(a) +Iniciar(b)},";
    }
  }