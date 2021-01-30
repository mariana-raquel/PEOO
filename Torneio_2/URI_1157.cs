using System;
  class MainClass {
    public static void Main(string[] args) {
      int a = int.Parse(Console.ReadLine());
      int i = a;
      while (i != 0) {
        if (a % i == 0){
          int d = a / i;
          Console.WriteLine(d);
        }
        i--;
      }
    }
  }