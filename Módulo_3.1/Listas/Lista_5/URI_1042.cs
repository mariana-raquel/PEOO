using System;
  class MainClass {
    public static void Main (string[] args) {
      string[] entrada = Console.ReadLine().Split(' ');
      int a = int.Parse(entrada[0]);
      int b = int.Parse(entrada[1]);
      int c = int.Parse(entrada[2]);
      int d = int.Parse(entrada[0]);
      int e = int.Parse(entrada[1]);
      int f = int.Parse(entrada[2]);

      int maior = Math.Max(a, Math.Max(b, c));
      int menor = Math.Min(a, Math.Min(b, c));
      int medio = (a + b + c) - maior - menor;
      Console.WriteLine(menor);
      Console.WriteLine(medio);
      Console.WriteLine(maior);
      Console.WriteLine();
      Console.WriteLine(d);
      Console.WriteLine(e);
      Console.WriteLine(f);
  }
}