using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite uma frase com três palavras:");
      string[] e = Console.ReadLine().Split(' ');
      string a = e[0];
      string b = e[1];
      string c = e[2];

      Console.WriteLine($"A sigla é {a[0]}{b[0]}{c[0]}");
    }
  }