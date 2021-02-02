using System;
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Digite a dimensão do ambiente em metros no formato largura X comprimento:");
      string[] da = Console.ReadLine().Split(" x ");
      double la = double.Parse(da[0]);
      double ca = double.Parse(da[1]);
      Console.WriteLine("Digite a dimensão do revestimento em centímetros no formato largura X comprimento:");
      string[] dr = Console.ReadLine().Split(" x ");
      double lr = double.Parse(dr[0]);
      double cr = double.Parse(dr[1]);
      Console.WriteLine("Digite o número de peças por caixa:");
      double np = double.Parse(Console.ReadLine());

      double aa = la * ca;
      double ar = (lr / 100) * (cr / 100);
      double cn = aa / ar;
      double c = cn / np;

      Console.WriteLine($"São necessárias {c:0.0} caixas do revestimento.");


      
    }
  }