using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Informe as suas notas dos 4 bimestres");
      double a = double.Parse(Console.ReadLine());
      double b = double.Parse(Console.ReadLine());
      double c = double.Parse(Console.ReadLine());
      double d = double.Parse(Console.ReadLine());

      double m = ((a * 2) + (b * 2) + (c * 3) + (d * 3)) / 10;

      if (m < 6) {
        Console.WriteLine("Informe sua nota na prova final");
        double nf = double.Parse(Console.ReadLine());
        double mf = (m + nf) / 2;
        if (mf >= 6) {Console.WriteLine("Você foi aprovado");}
        else { Console.WriteLine("Você foi reprovado");} 
      }
      if (m >= 6) {Console.WriteLine("Você foi aprovado");}
      
    }
  }