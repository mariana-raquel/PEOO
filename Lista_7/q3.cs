using System;
  class MainClass {
    public static void Main(string[] args) {
      Paciente p = new Paciente();
      Console.WriteLine("Qual o nome do paciente?");
      p.Nome = Console.ReadLine();
      Console.WriteLine("Qual o CPF?");
      p.CPF = Console.ReadLine();
      Console.WriteLine("Qual o Telefone?");
      p.Telefone = Console.ReadLine();
      Console.WriteLine("Qual a data de nascimento (mm-dd-aaaa)?");
      p.Nascimento = DateTime.Parse(Console.ReadLine());
      Console.WriteLine(p);
      Console.WriteLine($"O paciente tem {p.Idade}");
    }
  }
  class Paciente {
    private string nome,cpf, telefone;
    private DateTime nascimento;
    public string Nome {
      get { return nome; }
      set { if (value.Length > 0) nome = value; }
    }
    public string CPF {
      get { return cpf; }
      set { if (value.Length > 0) cpf = value; }
    }
    public string Telefone {
      get { return telefone; }
      set { if (value.Length > 0) telefone = value; }
    }
    public DateTime Nascimento{
      get { return nascimento; }
      set { if (nascimento.Month > 0 && nascimento.Day > 0) nascimento = value; }
    }
    public string Idade {
      get {
      DateTime da = DateTime.Now;
      
      int i = 0;
      if (da.Month < nascimento.Month && da.Day < nascimento.Day) {
        i = (da.Year - nascimento.Year) - 1;
      }
      if (da.Month >= nascimento.Month && da.Day >= nascimento.Day) {
        i = da.Year - nascimento.Year;
      }
      if (da.Month >= nascimento.Month && da.Day < nascimento.Day) {
        i = (da.Year - nascimento.Year) - 1;
      }
      if (da.Month < nascimento.Month && da.Day >= nascimento.Day) {
        i = (da.Year - nascimento.Year) - 1;
      }

      int m = 0;
      if (da.Month < nascimento.Month) { m = 12 + (da.Month - nascimento.Month);}
      if (da.Month == nascimento.Month) { m = 0; }
      if (da.Month > nascimento.Month) { m = da.Month - nascimento.Month ;}

      return $"{i} ano(s) e {m} mes(es)";
      }
    }
    public override string ToString() {
      return $"Nome: {nome} - CPF: {cpf} - Telefone: {telefone} - Nascimento: {nascimento:dd/MM/yyyy}";
    }
  }