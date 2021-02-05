using System;
  class MainClass {
    public static void Main(string[] args) {
      int e = int.Parse(Console.ReadLine());
      while (e != 0) {
        string[] pd = Console.ReadLine().Split(' ');
        int a = int.Parse(pd[0]);
        int b = int.Parse(pd[1]);
        int i = 1;
        while (i <= e) {
          string[] c = Console.ReadLine().Split(' ');
          int a1 = int.Parse(c[0]);
          int b1 = int.Parse(c[1]);
          if (a1 == a || a1 == b || b1 == a || b1 == b) {
            Console.WriteLine("divisa");
          }
          if (a1 > a && b1 > b) {
            Console.WriteLine("NE");
          }
          if (a1 < a && b1 > b) {
            Console.WriteLine("NO");
          }
          if (a1 > a && b1 < b) {
            Console.WriteLine("SE");
          }
          if (a1 < a && b1 < b) {
            Console.WriteLine("SO");
          }
          i++;
        }
      e = int.Parse(Console.ReadLine());
      } 
    }
  }
  /*
  if (a1 > a && b1 > b && a > 0 && b > 0) {
            Console.WriteLine("NE");
          }
          if (a1 < a && b1 > b && a < 0 && b > 0) {
            Console.WriteLine("NO");
          }
          if (a1 > a && b1 < b && a > 0 && b < 0) {
            Console.WriteLine("SE");
          }
          if (a1 < a && b1 < b && a < 0 && b < 0) {
            Console.WriteLine("SO");
  */