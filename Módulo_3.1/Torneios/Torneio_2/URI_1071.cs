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
      for (int i = a+1; i < b; i++){
        if (i % 2 != 0) { 
          p = p + i; 
        }
      }
      if (a == b) { p = 0;}

      Console.WriteLine(p);
    }
  }