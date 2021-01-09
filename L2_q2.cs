using System;
  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine("Digite seu nome completo:");
      string nome = Console.ReadLine();
      int e = nome.IndexOf(' ');
      string n = "";
      for (int i = 0; i < e; i++)
      {
        n = n + nome[i];
      }
      Console.WriteLine($"Bem vindo ao C#, {n}");
  }
}
