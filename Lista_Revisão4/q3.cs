using System;
  class MainClass {
    public static void Main(string[] args) {
      Paciente p1 = new Paciente("Maria", "123.456.789-10", "91112-1314", DateTime.Parse("01-01-2002"));
      Paciente p2 = new Paciente("José", "151.617.181-9", "92021-2223", DateTime.Parse("03-10-2003"));
      Paciente p3 = new Paciente("Ana", "242.526.272-8", "92930-3132", DateTime.Parse("06-20-2004"));
      Paciente p4 = new Paciente("João", "333.435.363-7", "93839-4041", DateTime.Parse("04-27-2021"));

      Hospital h = new Hospital();
      h.Inserir(p1);
      h.Inserir(p2);
      h.Inserir(p3);
      h.Inserir(p4);

      foreach (Paciente x in h.Listar()) {
        Console.WriteLine(x);
      }
    }
  }
  class Hospital {
    private Paciente[] paciente = new Paciente[20];
    private int k;
    public void Inserir(Paciente p) {
      if (k < 20) {
        paciente[k++] = p;
      }
    }
    public Paciente[] Listar() {
      Paciente[] novoPaciente = new Paciente[k];
      Array.Copy(paciente, novoPaciente, k);
      return novoPaciente;
    }
  }
  class Paciente {
    private string nome, cpf, telefone;
    private DateTime nascimento;
    public string Idade {
      get {
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
    } 
    public Paciente(string n, string c, string t, DateTime d) {
      try {
      if (n.Length > 0) nome = n;
      if (c.Length > 0) cpf = c;
      if (t.Length > 0) telefone = t;
      if (d.Day > 0 && d.Month > 0) nascimento = d;
      if (d.Year == DateTime.Now.Year && d.Month == DateTime.Now.Month && d.Day == DateTime.Now.Day|| d > DateTime.Now) throw new DataInvalidaException($"O Paciente {nome} foi cadastrado com a data de nascimento inválida.");
      }
      catch (DataInvalidaException obj) {
        Console.WriteLine(obj.Message);
        Console.WriteLine();
      }
    }
    public override string ToString() {
      return $"Nome: {nome} - CPF: {cpf} - Telefone: {telefone} - Data de nascimento: {nascimento:dd/MM/yyyy} - Idade: {Idade}";
    }
  }
  class DataInvalidaException : Exception {
    public DataInvalidaException(string m) : base(m) {}
  }