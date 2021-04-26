using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite o nome de quatro pessoas:");
      string a = Console.ReadLine();
      string b = Console.ReadLine();
      string c = Console.ReadLine();
      string d = Console.ReadLine();
      
      Console.WriteLine();
      string[] v = new string[] {a, b, c, d};
      Array.Sort(v);
      foreach (string e in v) {
        if (e == v[v.Length-1]) {
          Console.WriteLine($"{e}");
        }
        else { Console.Write($"{e}, "); }
      }
    }
  }