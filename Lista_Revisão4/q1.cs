using System;
using System.Collections.Generic;
  class MainClass {
    public static void Main(string[] args) {
      QuadroMedalhas q = new QuadroMedalhas();
      Pais a = new Pais();
      a.Nome = "Brasil";
      a.Ouro = 3;
      a.Prata = 7;
      a.Bronze = 8;

      Pais b = new Pais();
      b.Nome = "Argentina";
      b.Ouro = 1;
      b.Prata = 4;
      b.Bronze = 6;

      Pais c = new Pais();
      c.Nome = "Portugal";
      c.Ouro = 5;
      c.Prata = 9;
      c.Bronze = 2;

      q.Inserir(a);
      q.Inserir(b);
      q.Inserir(c);

      foreach (KeyValuePair<Pais, int> x in q.Listar()) {
        Console.WriteLine($"{x.Key} - Total: {x.Value} Medalha(s)");
      }
    }
  }
  class Pais : IComparable {
    private string nome;
    private int ouro, prata, bronze;
    public string Nome {
      get { return nome; }
      set { if (value.Length > 0) nome = value; }
    }
    public int Ouro {
      get { return ouro; }
      set { if (value > 0) ouro = value; }
    }
    public int Prata {
      get { return prata; }
      set { if (value > 0) prata = value; }
    }
    public int Bronze {
      get { return bronze; }
      set { if (value > 0) bronze = value; }
    }
    public int CompareTo(object obj) {
      if ((Ouro).CompareTo(((Pais) obj).Ouro) != 0) { 
        return -1*(Ouro).CompareTo(((Pais) obj).Ouro); 
      }
      else { 
        if ((Prata).CompareTo(((Pais) obj).Prata) != 0) {
          return -1*(Prata).CompareTo(((Pais) obj).Prata); 
        }
      else {
        if ((Bronze).CompareTo(((Pais) obj).Bronze) != 0) {
          return -1*(Bronze).CompareTo(((Pais) obj).Bronze);
        }
      else {
        return (Nome).CompareTo(((Pais) obj).Nome);
          }
        }
      }
    }
    public int TotalMed() {
      return Ouro + Prata + Bronze;
    }
    public override string ToString() {
      return $"Nome: {nome} - Ouro: {ouro} - Prata: {prata} - Bronze: {bronze}";
    }
  }
  class QuadroMedalhas {
    private SortedList<Pais, int> paises = new SortedList<Pais, int>();
    public void Inserir(Pais p) {
      paises.Add(p, p.TotalMed());
    }
    public SortedList<Pais, int> Listar() {
      return paises;
    }
  }
