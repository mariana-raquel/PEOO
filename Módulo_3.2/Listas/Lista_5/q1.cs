using System; 
  class MainClass {
    public static void Main (string[] args) {
      Paciente p = new Paciente("Mariana", "123.456.789-10", "91234-5678", DateTime.Parse("07-13-2004"));
      Console.WriteLine(p);
    }
  }
  class Paciente {
    private string nome, cpf, telefone;
    private DateTime nascimento;
    public Paciente(string n, string c, string t, DateTime nasc) {
      if (n.Length > 0) nome = n;
      if (c.Length > 0) cpf = c;
      if (t.Length > 0) telefone = t;
      if (nasc.Day > 0 && nasc.Month > 0) nascimento = nasc;
    }
    public string Idade() {
      int anos = 0;
      int meses = 0;
      DateTime hoje = DateTime.Now;
      if (hoje.Month > nascimento.Month) {
        anos += (hoje.Year - nascimento.Year);
        meses += (hoje.Month - nascimento.Month);
      }
      if (hoje.Month < nascimento.Month) {
        anos += (hoje.Year - nascimento.Year) - 1;
        meses += (hoje.Month - nascimento.Month) + 12;
      }
      if (hoje.Month == nascimento.Month && hoje.Day > nascimento.Day) {
        anos += (hoje.Year - nascimento.Year);
        meses += (hoje.Month - nascimento.Month);
      }
      if (hoje.Month == nascimento.Month && hoje.Day < nascimento.Day) {
        anos += (hoje.Year - nascimento.Year) - 1;
        meses += (hoje.Month - nascimento.Month) + 12;
      }
      if (hoje.Month == nascimento.Month && hoje.Day == nascimento.Day) {
        anos += (hoje.Year - nascimento.Year);
        meses += (hoje.Month - nascimento.Month);
      }
      return $"{anos} anos e {meses} meses";
    }
    public override string ToString() {
      return $"Nome: {nome} - CPF: {cpf} - Telefone: {telefone} - Data de nascimento: {nascimento:dd/MM/yyyy} - Idade: {Idade()}";
    }

  }