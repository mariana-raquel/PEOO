using System;
  class MainClass {
    public static void Main(string[] args) {
     int e = int.Parse(Console.ReadLine());
      while (e > 0) {
        string[] x = Console.ReadLine().Split(' ');
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);

        int r = a / b;
        if (a % b > 0) {r = r + 1;}
        Console.WriteLine(r);
        e--;
      }
    }
  }