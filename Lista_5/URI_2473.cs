using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] ent = Console.ReadLine().Split(' ');
      int a = int.Parse(ent[0]);
      int b = int.Parse(ent[1]);
      int c = int.Parse(ent[2]);
      int d = int.Parse(ent[3]);
      int e = int.Parse(ent[4]);
      int f = int.Parse(ent[5]);

      string[] ent2 = Console.ReadLine().Split(' ');
      int a2 = int.Parse(ent2[0]);
      int b2 = int.Parse(ent2[1]);
      int c2 = int.Parse(ent2[2]);
      int d2 = int.Parse(ent2[3]);
      int e2 = int.Parse(ent2[4]);
      int f2 = int.Parse(ent2[5]);

      int s = 0;

      if (a == a2 || a == b2 || a == c2 || a == d2 || a == e2 || a == f2) {
        s = s + 1;
      }
      if (b == a2 || b == b2 || b == c2 || b == d2 || b == e2 || b == f2) {
        s = s + 1;
      }
      if (c == a2 || c == b2 || c == c2 || c == d2 || c == e2 || c == f2) {
        s = s + 1;
      }
      if (d == a2 || d == b2 || d == c2 || d == d2 || d == e2 || d == f2) {
        s = s + 1;
      }
      if (e == a2 || e == b2 || e == c2 || e == d2 || e == e2 || e == f2) {
        s = s + 1;
      }
      if (f == a2 || f == b2 || f == c2 || f == d2 || f == e2 || f == f2) {
        s = s + 1;
      }
      
      if (s == 3) {
        Console.WriteLine("terno");
      }
      if (s == 4) {
        Console.WriteLine("quadra");
      }
      if (s == 5) {
        Console.WriteLine("quina");
      }
      if (s == 6) {
        Console.WriteLine("sena");
      }
      if (s < 3) {
        Console.WriteLine("azar");
      }

  }
}