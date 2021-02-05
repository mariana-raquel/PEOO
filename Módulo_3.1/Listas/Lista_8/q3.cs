using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a operação no formato op1+op2:");
      string[] e = Console.ReadLine().Split('+');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);

      int s = a + b;

      Console.WriteLine($"Soma = {s}");
    }
  }