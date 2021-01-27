using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] x = Console.ReadLine().Split(' ');
      int a = int.Parse(x[0]);
      int b = int.Parse(x[1]);
      int c = int.Parse(x[2]);
      int y = 0;
      if (a + b + c != y && // + todos (com os 3)
          a - b - c != y && // + a
        - a + b - c != y && // + b
        - a - b + c != y && // + c
          a + b - c != y && // + a e b
          a - b + c != y && // + a e c
        - a + b + c != y && // + b e c
        - a - b - c != y && // - todos
          a + b != y &&     // + a e b
          a - b != y &&     
        - a + b != y &&
        - a - b != y &&
          a + c != y &&
          a - c != y &&
        - a + c != y &&
        - a - c != y &&
          b + c != y &&
          b - c != y &&
        - b + c != y &&
        - b - c != y &&
         a != y &&
         b != y &&
         c != y &&
       - a != y &&
       - b != y &&
       - c != y) {
        Console.WriteLine("N");
      }

      if (a + b + c == y ||
          a - b - c == y ||
        - a + b - c == y ||
        - a - b + c == y ||
          a + b - c == y ||
          a - b + c == y ||
        - a + b + c == y ||
        - a - b - c == y ||
          a + b == y ||
          a - b == y ||
        - a + b == y ||
        - a - b == y ||
          a + c == y ||
          a - c == y ||
        - a + c == y ||
        - a - c == y ||
          b + c == y ||
          b - c == y ||
        - b + c == y ||
        - b - c == y) {
        Console.WriteLine("S");
       }      
  }
}