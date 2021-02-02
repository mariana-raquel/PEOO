using System;
  class MainClass {
   public static int MenorInteiro(double x) {
      int m = (int) x + 1;
      return m;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite um número real:");
      double x = double.Parse(Console.ReadLine());
      Console.WriteLine($"O seu menor inteiro é {MenorInteiro(x)}");
    } 
  }