using System;
  class MainClass {
   public static int Soma(int inicio, int fim) {
      int s = 0;
      while (inicio <= fim) {
        s += inicio;
        inicio++;
      }
      return s;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite o número inicial do seu intervalo:");
      int inicio = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o número final do seu intervalo:");
      int fim = int.Parse(Console.ReadLine());
      Console.WriteLine($"A soma dos número no seu intervalo é {Soma(inicio, fim)}");
    } 
  }