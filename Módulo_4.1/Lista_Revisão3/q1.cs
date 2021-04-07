using System;
  class MainClass {
    public static void Main(string[] args) {
      Livraria li = new Livraria("Livraria Ler & Aprender");
      Livro m1 = new Livro("De onde nascem as rosas", "Romance", 35.92);
      Livro m2 = new Livro("Orgulho e Preconceito", "Romance", 35.90);
      Livro m3 = new Livro("A culpa é das estrelas", "Romance", 22.88);
      Livro m4 = new Livro("A saga - Percy Jackson e os olimpianos", "Mitologia Grega", 127.50);
      Livro m5 = new Livro("A saga - Harry Potter", "Magia", 159.90);
      Livro m6 = new Livro("O diário de Anne Frank", "Biografia", 30.02);
      Livro m7 = new Livro("A saga - O senhor dos anéis", "Fantasia", 109.00);
      Livro m8 = new Livro("Brida", "Romance", 27.92);
      Livro m9 = new Livro("O Alquimista", "Literatura fantástica", 16.90);
      Livro m10 = new Livro("O Alienista", "Ficção", 20.08);
      Livro m11 = new Livro("Cicatrizes", "Romance", 50.00);
      Livro m12 = new Livro("Vidas secas", "Ficção", 27.90);
      Livro m13 = new Livro("A saga - Magnus Chase", "Mitologia Nórdica", 144.24);
      Livro m14 = new Livro("O guia do mochileiro das galáxias", "Ficção Científica", 19.69);
      Livro m15 = new Livro("O ódio que você semeia", "Romance", 28.90);
      Livro m16 = new Livro("A saga - Jogos vorazes", "Ficção Científica", 123.68);
      Livro m17 = new Livro("Uma dobra no tempo", "Romance", 18.90);
      Livro m18 = new Livro("O assassinato no expresso do Oriente", "Mistério", 29.90);
      Livro m19 = new Livro("Razão e sensibilidade", "Romance", 34.95);
      Livro m20 = new Livro("Ou isto ou aquilo", "Infanto Juvenil", 33.68);
     
      m1.Vender(59);
      m2.Vender(484);
      m3.Vender(252);
      m4.Vender(207);
      m5.Vender(419);
      m6.Vender(350);
      m7.Vender(296);
      m8.Vender(478);
      m9.Vender(289);
      m10.Vender(63);
      m11.Vender(314);
      m12.Vender(288);
      m13.Vender(495);
      m14.Vender(160);
      m15.Vender(390);
      m16.Vender(96);
      m17.Vender(284);
      m18.Vender(409);
      m19.Vender(364);
      m20.Vender(70);

      li.Inserir(m1);
      li.Inserir(m2);
      li.Inserir(m3);
      li.Inserir(m4);
      li.Inserir(m5);
      li.Inserir(m6);
      li.Inserir(m7);
      li.Inserir(m8);
      li.Inserir(m9);
      li.Inserir(m10);
      li.Inserir(m11);
      li.Inserir(m12);
      li.Inserir(m13);
      li.Inserir(m14);
      li.Inserir(m15);
      li.Inserir(m16);
      li.Inserir(m17);
      li.Inserir(m18);
      li.Inserir(m19);
      li.Inserir(m20);

      Console.WriteLine($"Bem-vindos a {li}!");
      Console.WriteLine($"Aqui temos um acervo com {li.Qtd} livros, são eles:");
      foreach (Livro j in li.Listar()) {
        if (j != null) { Console.WriteLine($"- {j.Titulo};"); }
      }
      Console.WriteLine();
      Console.WriteLine($"Temos os seguintes gêneros:");
      foreach (Livro j in li.ListarGenero()) {
        if (j != null) { Console.WriteLine($"- {j.GetGenero()};"); }
      }
      Console.WriteLine();
      Console.WriteLine("Nosso TOP 10 de vendas:");
      foreach (Livro j in li.Top10Vendidos()) {
        if (j != null) { Console.WriteLine($"Top {(Array.IndexOf(li.Top10Vendidos(), j))+1} {j.Titulo} - Com {j.Vendidos} exemplares vendidos!"); }
      }
    }
  }

  class Livro : IComparable {
    private string titulo, genero;
    private double precos;
    private int vendidos;
    public string Titulo {
      get { return titulo; }
    }
    public int Vendidos {
      get { return vendidos; }
    }
    public Livro (string t, string g, double p) {
      if (t.Length > 0) titulo = t;
      if (g.Length > 0) genero = g;
      if (p > 0) precos = p;
    }
    public int CompareTo (object obj) {
      return vendidos.CompareTo(((Livro)obj).vendidos);
    }
    public string GetGenero() {
      return genero;
    }
    public void Vender(int v) {
      if (v > 0) vendidos = v;
    }
    public override string ToString() {
      return $"Título: {titulo} - Gênero: {genero} - Preço: {precos:0.00} - Vendidos: {vendidos}";
    }
  }

  class Livraria {
    private string nome;
    Livro[] livros = new Livro[20];
    int qtd;
    public int Qtd {
      get { 
        foreach (Livro j in livros) {
          if (j != null)
            qtd += 1;
        }
        return qtd; 
      }
    }
    public Livraria (string n) {
      if (n.Length > 0) nome = n;
    }
    int i = 0;
    public void Inserir(Livro l) {
      livros[i] = l;
      i++;
    }
    public void Remover (Livro l) {
      int w = Array.IndexOf(livros, l);
      if (w != -1) {
        for (int p = w; p <= i; p++) {
          livros[p] = livros[p+1];
          i--;
        }
      }
    }
    public Livro[] Listar() {
      return livros;
    }
    public Livro[] ListarGenero() {
      return livros;
    }
    public Livro[] Top10Vendidos() {
      Array.Sort(livros);
      Array.Reverse(livros);
      Livro[] newLivros = new Livro[10];
      Array.Copy(livros, newLivros, 10);
      return newLivros;
    }
    public override string ToString() {
      return $"{nome}";
    }
  }