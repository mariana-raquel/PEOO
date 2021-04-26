using System;
  class MainClass {
    public static void Main(string[] args) {
      Colecao c = new Colecao(10);
      c.Inserir(1);
      c.Inserir(2);
      c.Inserir(3);
      c.Inserir(4);
      Console.WriteLine(c.NumItens());
      foreach (Colecao i in c.Listar()) {
        Console.WriteLine(i);
      }
    }
  }
  class Colecao {
    object[] itens = new object[10];
    private int max;
    public Colecao(int max) {
      if (max > 0) this.max = max;
    }
    int a = 0; 
    public void Inserir(object item) {
      object[] itens = new object[max];
      itens[a] = item;
      a++;
    }
    public object[] Listar() {
      return itens;
    }
    public int NumItens() {
      return itens.Length;
    }
  }