using System;
  class MainClass {
    public static void Main (string[] args) {
      int e = int.Parse(Console.ReadLine());
      int s = 0;
      int c = 1;
      while (c <= e){
        int a = int.Parse(Console.ReadLine());
        int i = 1;
        double r = Math.Sqrt(a);
        while (i <= r) {
          Console.WriteLine(a);
          if (a % i == 0 ) { s = s + 1; }
          i++;
          Console.WriteLine(s);
        }
        if (s == 2) { Console.WriteLine("Prime"); }
        if (s != 2) { Console.WriteLine("Not Prime"); }
        Console.WriteLine(s);
        s = 0;
        c++;
        Console.WriteLine(s);
    }
  }
  }