using System;
using System.Collections.Generic;
  class MainClass {
    public static void Main(string[] args) {
      Construtora c = new Construtora();
      Funcionario f1 = new Funcionario();
      f1.SetNome("Mariana");
      f1.SetEmail("aeiou");
      f1.SetFone("1234-5678");

      Motorista f2 = new Motorista();
      f2.SetNome("Adriana");
      f2.SetEmail("bcdfg");
      f2.SetFone("8765-4321");
      f2.SetCnh("cccccc");

      Engenheiro f3 = new Engenheiro();
      f3.SetNome("José");
      f3.SetEmail("hjklm");
      f3.SetFone("1357-91113");
      f3.SetCrea("aaaaaa");

      Motorista f4 = new Motorista();
      f4.SetNome("João");
      f4.SetEmail("npqrs");
      f4.SetFone("2468-1012");
      f4.SetCnh("dddddd");

      Engenheiro f5 = new Engenheiro();
      f5.SetNome("Maria");
      f5.SetEmail("tvwxy");
      f5.SetFone("1517-1921");
      f5.SetCrea("bbbbbb");

      Funcionario f6 = new Funcionario();
      f6.SetNome("Juan");
      f6.SetEmail("zabcd");
      f6.SetFone("1416-1820");

      c.Inserir(f1);
      c.Inserir(f2);
      c.Inserir(f3);
      c.Inserir(f4);
      c.Inserir(f5);
      c.Inserir(f6);

      Console.WriteLine("Todos os funcionários:");
      foreach (Construtora x in c.Funcionarios()) {
        Console.WriteLine(x);
      }
      Console.WriteLine();

      Console.WriteLine("Engenheiros:");
      foreach (Construtora y in c.Engenheiros()) {
        Console.WriteLine(y);
      }
      Console.WriteLine();

      Console.WriteLine("Motoristas:");
      foreach (Construtora z in c.Motoristas()) {
        Console.WriteLine(z);
      }


    }
  }
  class Construtora {
    private List<Funcionario> funcs = new List<Funcionario>();
    public void Inserir(Funcionario f) {
      funcs.Add(f);
    }
    public List<Funcionario> Funcionarios() {
      return funcs;
    }
    public List<Engenheiro> Engenheiros() {
      List<Engenheiro> engs = new List<Engenheiro>();
      foreach (Funcionario x in Funcionarios()) {
        if (x is Engenheiro) {
          engs.Add(x as Engenheiro);
        }
      }
      return engs;
    }
    public List<Motorista> Motoristas() {
      List<Motorista> moto = new List<Motorista>();
      foreach (Funcionario x in Funcionarios()) {
        if (x is Motorista) {
          moto.Add(x as Motorista);
        }
      }
      return moto;
    }
  }

  class Funcionario : Construtora {
    private string nome, email, fone;
    public void SetNome(string n) {
      if (n.Length > 0) nome = n;
    }
    public void SetEmail(string e) {
      if (e.Length > 0) email = e;
    }
    public void SetFone(string f) {
      if (f.Length > 0) fone = f;
    }
    public string GetNome() {
      return nome;
    }
    public string GetEmail() {
      return email;
    }
    public string GetFone() {
      return fone;
    }
    public override string ToString() {
      return $"Nome: {nome} - Email: {email} - Fone: {fone}";
    }
  }

  class Engenheiro : Funcionario {
    private string crea;
    public void SetCrea(string c) {
      if (c.Length > 0) crea = c;
    }
    public string GetCrea() {
      return crea;
    }
    public override string ToString() {
      return $"Nome: {base.GetNome()} - Email: {base.GetEmail()} - Fone: {base.GetFone()} - Crea: {crea}";
    }
  }

  class Motorista : Funcionario {
    private string cnh;
    public void SetCnh(string c) {
      if (c.Length > 0) cnh = c;
    }
    public string GetCnh() {
      return cnh;
    }
    public override string ToString() {
      return $"Nome: {base.GetNome()} - Email: {base.GetEmail()} - Fone: {base.GetFone()} - Cnh: {cnh}";
    }
  }