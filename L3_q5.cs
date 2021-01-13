using System;
  class MainClass {
    public static void Main (string[] args) {
      int e = int.Parse(Console.ReadLine());

      int cm = e / 100;
      int cnqunt = e % 100 / 50;
      int vnt = e % 100 % 50 / 20;
      int dz = e % 100 % 50 % 20 / 10;
      int cnc = e % 100 % 50 % 20 % 10 / 5;
      int ds = e % 100 % 50 % 20 % 10 % 5 / 2;
      int um = e % 100 % 50 % 20 % 10 % 5 % 2 / 1;
      Console.WriteLine(e);
      Console.WriteLine($"{cm} nota(s) de R$ 100,00");
      Console.WriteLine($"{cnqunt} nota(s) de R$ 50,00");
      Console.WriteLine($"{vnt} nota(s) de R$ 20,00");
      Console.WriteLine($"{dz} nota(s) de R$ 10,00");
      Console.WriteLine($"{cnc} nota(s) de R$ 5,00");
      Console.WriteLine($"{ds} nota(s) de R$ 2,00");
      Console.WriteLine($"{um} nota(s) de R$ 1,00");
       
  }
}
