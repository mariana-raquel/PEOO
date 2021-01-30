using System;
  class MainClass {
    public static void Main(string[] args) {
      int x = int.Parse(Console.ReadLine());
      int i = 1;
      while (i <= x) {
        string[] e = Console.ReadLine().Split(' ');
        int a = int.Parse(e[0]);
        int b = int.Parse(e[1]);
        double c = double.Parse(e[2]);
        double d = double.Parse(e[3]);
        int s = 0;
        double va = (c / 100) * a;
        double vb = (d / 100) * b;
        while (a <= b) {
          va = (c / 100) * a;
          vb = (d / 100) * b;
          a = a + (int) va;
          b = b + (int) vb;
          s++;
          if (s > 100) {
            Console.WriteLine($"Mais de 1 seculo.");
            break;
          }
        }
        if (s <= 100) {Console.WriteLine($"{s} anos.");} 
       i++;
      }
    }  
  }