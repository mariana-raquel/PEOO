using System;
  class MainClass {
    public static void Main (string[] args) {
      double e = double.Parse(Console.ReadLine());
      
      if (e >= 0 & e <= 25) { 
        Console.WriteLine($"Intervalo [0,25]");
      }
      if (e > 25 & e <= 50) { 
        Console.WriteLine($"Intervalo (25,50]");
      }
      if (e > 50 & e <= 75) { 
        Console.WriteLine($"Intervalo (50,75]");
      }
      if (e > 75 & e <= 100) { 
        Console.WriteLine($"Intervalo (75,100]");
      }
      if (e < 0 || e > 100) { 
        Console.WriteLine($"Fora de intervalo");
      }
  }
}