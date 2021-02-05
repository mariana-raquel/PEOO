using System;
  class MainClass {
    public static void Main(string[] args) {
      double s = double.Parse(Console.ReadLine());

      if (s >= 0 && s <= 400) {
        double r = (s * 0.15);
        double ns = (s + r);
        Console.WriteLine($"Novo salario: {ns:0.00}");
        Console.WriteLine($"Reajuste ganho: {r:0.00}");
        Console.WriteLine($"Em percentual: 15 %");
      }
       if (s > 400 && s <= 800) {
        double r = (s * 0.12);
        double ns = (s + r);
        Console.WriteLine($"Novo salario: {ns:0.00}");
        Console.WriteLine($"Reajuste ganho: {r:0.00}");
        Console.WriteLine($"Em percentual: 12 %");
      } 
       if (s > 800 && s <= 1200) {
        double r = (s * 0.10);
        double ns = (s + r);
        Console.WriteLine($"Novo salario: {ns:0.00}");
        Console.WriteLine($"Reajuste ganho: {r:0.00}");
        Console.WriteLine($"Em percentual: 10 %");
      }
       if (s > 1200 && s <= 2000) {
        double r = (s * 0.07);
        double ns = (s + r);
        Console.WriteLine($"Novo salario: {ns:0.00}");
        Console.WriteLine($"Reajuste ganho: {r:0.00}");
        Console.WriteLine($"Em percentual: 7 %");
      }
       if (s > 2000) {
        double r = (s * 0.04);
        double ns = (s + r);
        Console.WriteLine($"Novo salario: {ns:0.00}");
        Console.WriteLine($"Reajuste ganho: {r:0.00}");
        Console.WriteLine($"Em percentual: 4 %");
      }


    }
  }