using System;
  class MainClass {
    public static void Intervalo(double x, out int inicio, out int fim) {
      int i = (int) x;
      int f = x + 1;
    }
    public static void Main(string[] args){
      //double a  = double.Parse(Console.ReadLine());
      a = 4.5;
      Intervalo(a, out int i, out int f);
      Console.WriteLine(i);
      Console.WriteLine(f);
      Console.WriteLine($"[{i}, {f}]");
    }
  }