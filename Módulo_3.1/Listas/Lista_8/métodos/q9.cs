using System;
  class MainClass {
    public static string Palavra(string texto, int pos) {
      string[] s = texto.Split(' ');
      if (pos > s.Length-1) {
        
      }
      else { 
        string i = s[pos];
        return i;
      }
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite uma frase:");
      string texto = Console.ReadLine();
      Console.WriteLine("Digite uma frase:");
      int pos = int.Parse(Console.ReadLine());
      Palavra(texto, pos);
      if (pos > testo.Length-1) {
        Console.WriteLine("Essa posição não existe neste texto");
      }
      else {
      Console.WriteLine($"As iniciais da sua frase são {Palavra(texto, pos)}");
      }
    } 
  }