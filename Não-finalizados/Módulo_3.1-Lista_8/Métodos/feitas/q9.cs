using System;
  class MainClass {
    public static string Palavra(string texto, int pos) {
      string[] s = texto.Split(' ');
      if (pos < s.Length-1) {
        string i = s[pos];
        return i;
      }
      else { 
        return "A posição que procura não existe nesse texto";
      }
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite uma frase:");
      string texto = Console.ReadLine();
      Console.WriteLine("Digite a posição que deseja procurar:");
      int pos = int.Parse(Console.ReadLine());
      if (pos > texto.Split(' ').Length-1) Console.WriteLine(Palavra(texto, pos));
      else Console.WriteLine($"A palavra da posição procurada é '{Palavra(texto, pos)}'"); 
    }
  } 
  