using System;
  class MainClass {
    public static void Main (string[] args) {
      int e = int.Parse(Console.ReadLine());
      int c = 1;
      int s = 0;
      while (c <= e){
        int a = int.Parse(Console.ReadLine());
        int i = 2;
        double r = Math.Sqrt(a);
        while (i <= r) {
          if (a % i == 0 ) { s = s + 1; }
          i++;
        }
        
        if (s > 0) { Console.WriteLine("Not Prime"); }
        else {
          Console.WriteLine("Prime");
        }
        c++;
         s = 0;
      }
    }
  }