using System;
using System.Collections.Generic;
  class MainClass {
    public static void Main(string[] args) {

    }
  }
  class Construtora {
    private List<Funcionario> funcs = new List<Funcionario>();
    public void Inserir(Funcionario f) {
      funcs.Add(f);
    }
    /*public List<Funcionario> Funcionarios() {

    }
    public List<Engenheiro> Engenheiros() {

    }
    public List<Motorista> Motoristas() {

    }*/
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
      return $"Crea: {crea}";
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
      return $"Cnh: {cnh}";
    }
  }