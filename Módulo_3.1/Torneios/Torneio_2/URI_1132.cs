using System;
  class MainClass {
    public static void Main(string[] args) {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int p = 0;
      int aux;

      if (b < a) {
        aux = a;
        a = b;
        b = aux;
      }
      while (a <= b) {
        if (a % 13 > 0) { 
          p = p + a;
        }
        a++;
      }
      Console.WriteLine(p);
    }
  }