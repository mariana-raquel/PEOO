using System;
  class MainClass {
    public static string Iniciais(string s) {
      string i = s[0] + "";
      int e = s.IndexOf(' ');
      while (e != -1) {
          i += s[e+1];
          s = s.Remove(0,e+1);
          e = s.IndexOf(' ');
      }
      return i;
    }
    public static void Main(string[] args) {
      Console.WriteLine("Digite uma frase:");
      string s = Console.ReadLine();
      Console.WriteLine($"As iniciais da sua frase são {Iniciais(s)}");
    } 
  }