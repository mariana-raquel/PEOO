using System;
  class MainClass {
    public static void Main (string[] args) {
      Console.WriteLine("Digite seu nome completo:");
      string[] nome = Console.ReadLine().Split(' ');
      string n1 = nome[0];
      Console.WriteLine($"Bem-vindo ao C#, {n1}");
  }
}
