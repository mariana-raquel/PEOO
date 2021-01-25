using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] entrada = Console.ReadLine().Split(' ');
      int a = int.Parse(entrada[0]);
      int b = int.Parse(entrada[1]);
      int c = int.Parse(entrada[2]);
      int d = int.Parse(entrada[3]);
      int e = int.Parse(entrada[4]);

  
      if (a < b && b < c && c < d && d < e) { 
          Console.WriteLine("C");
        }
        else {
            if (a > b && b > c && c > d && d > e) {
              Console.WriteLine("D");
            }
            else {
                Console.WriteLine("N");
            }
        }
      
  }
}