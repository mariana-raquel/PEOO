using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] e = Console.ReadLine().Split(' ');
      int a = int.Parse(e[0]);
      int b = int.Parse(e[1]);
      int c = int.Parse(e[2]);

      int m1 = Math.Max(a, b);
      int m2 = Math.Max(m1, c);

      Console.WriteLine($"{m2} eh o maior");
       
  }
}
