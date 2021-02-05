using System;
  class MainClass {
    public static double Maior(double x, double y) {
    double maior = Math.Max(x, y);
    return maior;
  }
   public static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(x, y));
  }
}
