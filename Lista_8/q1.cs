using System;
using System.Collections;
  class MainClass {
    public static void Main(string[] args) {
      Aluno a = new Aluno();
      a.Nome = "Mariana";
      a.Matricula = "20191011110004";
      a.Nascimento = DateTime.Parse("07-13-2004");

      Aluno b = new Aluno();
      b.Nome = "Adriana";
      b.Matricula = "20191011110003";
      b.Nascimento = DateTime.Parse("10-22-1974");

      Aluno c = new Aluno();
      c.Nome = "Terezinha";
      c.Matricula = "20191011110001";
      c.Nascimento = DateTime.Parse("03-24-1950");

      Console.WriteLine("Por ordem alfabética:");
      Aluno[] alunos = {a, b, c};
      Array.Sort(alunos);
      foreach (Aluno i in alunos) {
        Console.WriteLine(i);
      }
      Console.WriteLine();

      Console.WriteLine("Por matrícula:");
      Array.Sort(alunos, new AlunoMatriculaComp());
      foreach (Aluno n in alunos) {
        Console.WriteLine(n);
      }
      Console.WriteLine();

      Console.WriteLine("Por idade:");
      Array.Sort(alunos, new AlunoNascimentoComp());
      Array.Reverse(alunos);
      foreach (Aluno m in alunos) {
        Console.WriteLine(m);
      }
    }
  }
  class Aluno : IComparable {
    private string nome, matricula;
    private DateTime nasc;
    public string Nome {
      get { return nome; }
      set { if (value.Length > 0) nome = value; }
    }
    public string Matricula {
      get { return matricula; }
      set { if (value.Length > 0) matricula = value; }
    }
    public DateTime Nascimento {
      get { return nasc; }
      set { if (value.Day > 0 && value.Month > 0) nasc = value; }
    }
    public int CompareTo(object obj) {
      return nome.CompareTo(((Aluno) obj).nome);
    }
    public override string ToString() {
      return $"Nome: {nome} - Matrícula: {matricula} - Data de nascimento: {nasc:dd/MM/yyyy}";
    }
  }
  class AlunoMatriculaComp : IComparer {
    public int Compare(object x, object y) {
      Aluno a = (Aluno) x;
      Aluno b = (Aluno) y;
      return a.Matricula.CompareTo(b.Matricula);
    } 
  }
  class AlunoNascimentoComp : IComparer {
    public int Compare(object x, object y) {
      Aluno a = (Aluno) x;
      Aluno b = (Aluno) y;
      return a.Nascimento.CompareTo(b.Nascimento);
    } 
  }