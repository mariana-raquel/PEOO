using System;
  class MainClass {
    public static void Main (string[] args) {
      string x = Console.ReadLine();
      while (x != "*") {
        x = x.ToLower();
        char c = x[0];
        int m = 0;
        for (int i = 1; i < x.Length; i++) {
          if (x[i] == ' ' && c != x[i+1]) { m = m + 1;}
        }
        if (m == 0) { 
          Console.WriteLine("Y");
          }
        else {
          Console.WriteLine("N");
          }
        x = Console.ReadLine();
      }
  }
}