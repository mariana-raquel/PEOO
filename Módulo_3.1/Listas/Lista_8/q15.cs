using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite o nome de quatro pessoas:");
      string a = Console.ReadLine();
      string b = Console.ReadLine();
      string c = Console.ReadLine();
      string d = Console.ReadLine();

      char a1 = a[0];
      char b1 = b[0];
      char c1 = c[0];
      char d1 = d[0];

      if (a1 < b1 && b1 < c1 && c1 < d1) {
        Console.WriteLine($"{a}, {b}, {c} e {d}");
      }
      if (a1 < b1 && b1 < c1 && c1 > d1) {
        Console.WriteLine($"{a}, {b}, {d} e {c}");
      }
      if (a1 < b1 && b1 > c1 && b1 > d1 && c1 > d1) {
        Console.WriteLine($"{a}, {c}, {d} e {b}");
      }
      /*if (a1 > b1 && b1 > c1 && c1 > d1) {
        Console.WriteLine($"{}, {}, {} e {}");
      }
      if (a1 > b1 && b1 < c1 && c1 > d1) {
        Console.WriteLine($"{}, {}, {} e {}");
      }
      if (a1 < b1 && b1 < c1 && c1 < d1) {
        Console.WriteLine($"{}, {}, {} e {}");
      }
      if (a1 < b1 && b1 < c1 && c1 < d1) {
        Console.WriteLine($"{}, {}, {} e {}");
      }*/


      
    }
  }