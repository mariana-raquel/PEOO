using System;
  class Aluno /*: IComparable */{
    public string Nome { get; set; }
    public string Idade { get; set; }
    /*public int CompareTo(object obj) {
     return Nome.CompareTo(((Aluno)obj).Nome);
    }*/
  }
  class MainClass {
    public static void Main(string[] args) {
      Aluno[] v = new [] {
        new Aluno { Nome = "Leonardo", Idade = "40"},
        new Aluno { Nome = "Gilbert", Idade = "50"}
      };
      Array.Sort(v);
      Console.WriteLine(v[0].Nome);
      Console.WriteLine(v[1].Nome);
    }
  }