using System;
  class MainClass {
    public static void Ordenar(ref int x, ref int y, ref int z) {
      int aux;
      if (x > y) {
        aux = x;
        x = y;
        y = aux;
      }
      if (x > z) {
        aux = x;
        x = z;
        z = aux;
      }
      if (y > z) {
        aux = y;
        y = z;
        z = aux;
      }
    }
    public static void Main(string[] args) {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int c = int.Parse(Console.ReadLine());
      Ordenar(ref a, ref b, ref c);
      Console.WriteLine("Números ordenados");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);

    }
  }
