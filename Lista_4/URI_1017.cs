using System;
  class MainClass {
    public static void Main (string[] args) {
      double t = double.Parse(Console.ReadLine());
      double d = double.Parse(Console.ReadLine());

      double g = (t * d) / 12;
    
      Console.WriteLine($"{g:0.000}");
  }
}