using System;
  class MainClass {
    public static void Main (string[] args) {
      int e = int.Parse(Console.ReadLine());
      int i = 1;
      while (i <= 10) {
        int m = i * e;
        Console.WriteLine($"{i} x {e} = {m}");
        i++;
      }
  }
}