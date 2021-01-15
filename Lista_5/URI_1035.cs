using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      int c = int.Parse(e[2]);
      int d = int.Parse(e[3]);
    
      if (b > c & d > a & (c + d) > (a + b) & c > 0 & d > 0 & a % 2 == 0) 
      {
        Console.WriteLine($"Valores aceitos");
      }
      else {
        Console.WriteLine($"Valores nao aceitos");
      }
      
  }
}