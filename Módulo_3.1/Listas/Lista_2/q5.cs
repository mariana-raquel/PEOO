using System;
  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
      string[] b = Console.ReadLine().Split(':');
      long h = long.Parse(b[0]);
      long m = long.Parse(b[1]);
      long s = long.Parse(b[2]);

      long s1= (h * 60 * 60) * (m * 60) * s;
     
      long d = s1 * 300000;

      Console.WriteLine($"A luz percorreu {d} km nesse intervalo");   
  }
}
