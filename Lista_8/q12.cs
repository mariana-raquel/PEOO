using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a placa de um veículo (com letras e números)");
      string v = Console.ReadLine();
      int t = v.Length;
      char f = v[t-1];

      if (f == '1' || f == '2') {
        Console.WriteLine("Fevereiro");
      }
      if (f == '3' || f == '4') {
        Console.WriteLine("Março");
      }
      if (f == '5' || f == '6') {
        Console.WriteLine("Abril");
      }
      if (f == '7' || f == '8') {
        Console.WriteLine("Maio");
      }
      if (f == '9' || f == '0') {
        Console.WriteLine("Junho");
      }


      
    }
  }