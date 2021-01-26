using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      
      if (b >= 0 && b <= 2) {
      Console.WriteLine("nova");
      }
      if (b >= 97 && b <= 100) {
      Console.WriteLine("cheia");
      }
      if (a < b && b >= 3 && b <= 96) {
      Console.WriteLine("crescente");
      }
      if (b < a && b >= 3 && b <= 96) {
      Console.WriteLine("minguante");
      }
      
  }
}