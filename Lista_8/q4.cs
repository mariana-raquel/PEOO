using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite três valores separados por vírgulas:");
      string[] e = Console.ReadLine().Split('.', ',');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      int c = int.Parse(e[2]);

      int p = a * b * c;
      
      Console.WriteLine($"O produto entre os valores é {p}");
    }
  }