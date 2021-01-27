using System;
  class MainClass {
    public static string FormatarTexto(string texto) {
      texto = texto.Trim();
      int e  = texto.IndexOf(' ');
      while (e != -1) {
        texto = texto.Remove(e, 1);
        e  = texto.IndexOf(' ');
      }
      return texto;
    }
    public static void Main(string[] args){
      string texto = Console.ReadLine();
      Console.WriteLine(FormatarTexto(texto));
    }
  }