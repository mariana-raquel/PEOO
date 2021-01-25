using System;
  class MainClass {
    public static void Ordenar(ref int x, ref int y, ref int z) {
      int maior = Math.Max(x,Math.Max(y,z));
      int menor = Math.Min(x,Math.Min(y,z)); 
      int medio = (x + y + z) - (maior - menor);
      int l = { maior +  medio +  menor };
      return l;
    }
    public static void Main(string[] args) {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int c = int.Parse(Console.ReadLine());
      Console.WriteLine(Ordenar(ref a, ref b, ref c));
    }
  }
