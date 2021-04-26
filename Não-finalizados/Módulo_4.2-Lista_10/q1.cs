using System;
using System.Collections.Generic;
  class MainClass {
    public static void Main(string[] args) {
      Aluno a = new Aluno();
      a.Nome = "Mariana";
      a.Curso = "Informática p/ Internet";

      Aluno a1 = new Aluno();
      a1.Nome = "Jadhy";
      a1.Curso = "Edificações";

      Coleção<Aluno> b = new Coleção<Aluno>();
      b.Add(a);
      b.Add(a1);

      Console.WriteLine(a);
      Console.WriteLine(a1);
    }
  }
  class Aluno : IComparable<Aluno> {
    private string nome, curso;
    public string Nome { 
      get { return nome; }
      set { if (value.Length > 0) this.nome = value; }
    }
    public string Curso { 
      get { return curso; }
      set { if (value.Length > 0) this.curso = value; }
    }
    public int CompareTo(Aluno obj) {
      return Nome.CompareTo(obj.Nome);
    }
    public override string ToString() {
      return $"Nome: {Nome} - Curso: {Curso}";
    }
  } 
  class Coleção<T> /*: IEnumerable<T> */{
    private T[] objs = new T[40];
    private int k;
    public int Count {
      get { return k; }
    }
    public void Add(T obj) {
      if (k < 40) objs[k++] = obj;
    }
    public void Remove(T obj) {
      int i = Array.IndexOf(objs, obj);
      if (i != -1) {
        for (int a = i; a <= k; a++) {
          objs[a] = objs[a+1];
          k--;
        }
      }
    }
    public void Sort() {
      T[] na = new T[k];
      Array.Copy(objs, na, k);
      Array.Sort(na);
      na.CopyTo(objs, 0);
    }/*
    public IEnumerator<T> GetEnumerator() {
      T[] v = new T[k];
      Array.Copy(objs, v, k);
      return v.GetEnumerator();
    }*/
  }