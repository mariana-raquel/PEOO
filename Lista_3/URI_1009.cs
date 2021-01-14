using System;
  class MainClass {
    public static void Main (string[] args) {
      string nome = Console.ReadLine();
      double sf = double.Parse(Console.ReadLine());
      double v = double.Parse(Console.ReadLine());
      double c = v * 0.15;
      double st = sf + c;
      Console.WriteLine($"TOTAL = R$ {st:0.00}"); 
  }
}
