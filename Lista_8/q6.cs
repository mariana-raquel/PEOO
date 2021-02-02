using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a largura do ambiente em metros:");
      double la = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o comprimento do ambiente em metros:");
      double ca = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a largura do revestimento em centímetros:");
      double lr = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o comprimento do revestimento em centímetros:");
      double cr = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o número de peças por caixa:");
      double np = double.Parse(Console.ReadLine());

      double aa = la * ca;
      double ar = (lr / 100) * (cr / 100);
      double cn = aa / ar;
      double c = cn / np;

      Console.WriteLine($"São necessárias {c:0.0} caixas do revestimento.");

    
      
    }
  }