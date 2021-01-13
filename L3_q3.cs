using System;
  class MainClass {
    public static void Main (string[] args) {
      double a = double.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());
    
      double dp = a / b;

      Console.WriteLine($"{dp:0.000} km/l");
       
  }
}
