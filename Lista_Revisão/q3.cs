using System;
  class MainClass {
    public static void Main(string[] args) {
      Pessoa p = new Pessoa();
      Console.WriteLine($"Digite seu nome:");
      p.SetNome(Console.ReadLine());
      Console.WriteLine($"Digite sua idade no formato mm/dd/aaaa:");
      p.SetNascimento(DateTime.Parse(Console.ReadLine()));
      Console.WriteLine($"Olá {p.GetNome()}, você tem (ou irá fazer esse ano) {p.Idade()} anos");
    }
  }
  class Pessoa {
    private string nome;
    private DateTime nascimento;
    public void SetNome(string nome) {
      if (nome.Length > 0) { this.nome = nome; }
    }
    public void SetNascimento(DateTime nascimento) {
      if (nascimento.Day > 0 && nascimento.Month > 0 && nascimento.Year > 0) { this.nascimento = nascimento; }
    }
    public string GetNome() {
      return nome;
    }
    public DateTime GetNascimento() {
      return nascimento;
    }
    public int Idade() {
      int i = DateTime.Now.Year - nascimento.Year;
      return i;
    }
  }