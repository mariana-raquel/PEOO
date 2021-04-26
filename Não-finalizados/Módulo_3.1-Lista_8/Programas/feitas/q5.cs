using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite uma frase com três palavras:");
      string [] e = Console.ReadLine().Split(' ');
      string a = e[0];
      string b = e[1];
      string c = e[2];

      int t1 = a.Length;
      int t2 = b.Length;
      int t3 = c.Length;

      Console.WriteLine($"A senha é {t1}{t2}{t3}");
    }
  }