using System;
  class MainClass {
    public static void Main(string[] args) {
      Loja l = new Loja();
      l.Nome = "Game Store";

      Aplicativo a = new Aplicativo();
      a.Nome = "Assetto Corsa"; 
      a.Categoria = "Simulação"; 
      a.Preço = Convert.ToDecimal(54.00); 
      a.Curtir(96);

      Aplicativo b = new Aplicativo();
      b.Nome = "Grand Theft Auto V"; 
      b.Categoria = "Sandbox"; 
      b.Preço = Convert.ToDecimal(73.00); 
      b.Curtir(80);

      Aplicativo c = new Aplicativo();
      c.Nome = "Call of Duty Cold War"; 
      c.Categoria = "FPS"; 
      c.Preço = Convert.ToDecimal(188.70); 
      c.Curtir(76);

      Aplicativo d = new Aplicativo();
      d.Nome = "The Elder Scrolls 5 Skyrim"; 
      d.Categoria = "RPG"; 
      d.Preço = Convert.ToDecimal(97.35); 
      d.Curtir(93);

      Aplicativo e = new Aplicativo();
      e.Nome = "DayZ"; 
      e.Categoria = "Sobrevivência"; 
      e.Preço = Convert.ToDecimal(190.50); 
      e.Curtir(87);

      Aplicativo f = new Aplicativo();
      f.Nome = "Fallout 4"; 
      f.Categoria = "Pós-Apocaliptico"; 
      f.Preço = Convert.ToDecimal(56.00); 
      f.Curtir(70);

      Aplicativo g = new Aplicativo();
      g.Nome = "Sims 4"; 
      g.Categoria = "Simulação"; 
      g.Preço = Convert.ToDecimal(64.00); 
      g.Curtir(83);

      Aplicativo h = new Aplicativo();
      h.Nome = "FIFA 21"; 
      h.Categoria = "Futebol"; 
      h.Preço = Convert.ToDecimal(144.99); 
      h.Curtir(78);

      Aplicativo i = new Aplicativo();
      i.Nome = "Shogun 2 Total War"; 
      i.Categoria = "Estratégia"; 
      i.Preço = Convert.ToDecimal(154.00); 
      i.Curtir(81);

      Aplicativo j = new Aplicativo();
      j.Nome = "Hitman 3"; 
      j.Categoria = "Stealth "; 
      j.Preço = Convert.ToDecimal(173.30); 
      j.Curtir(74);

      Aplicativo k = new Aplicativo();
      k.Nome = "Minecraft"; 
      k.Categoria = "Sobrevivência"; 
      k.Preço = Convert.ToDecimal(29.90); 
      k.Curtir(95);

      l.Inserir(a);
      l.Inserir(b);
      l.Inserir(c);
      l.Inserir(d);
      l.Inserir(e);
      l.Inserir(f);
      l.Inserir(g);
      l.Inserir(h);
      l.Inserir(i);
      l.Inserir(j);
      l.Inserir(k);

      Console.WriteLine($"Bem-vindos a {l.Nome}. Nós temos {l.Qtd} jogos no estoque, sendo eles:");
      foreach (Aplicativo w in l.Listar()) {
        if (w != null) Console.WriteLine($"- {w};"); 
      }
      Console.WriteLine();
      
      Console.WriteLine($"Resultados da sua busca:");
      foreach (Aplicativo r in l.Pesquisar("Sobrevivência")) {
        if (r != null) Console.WriteLine($"- {r};"); 
      }
      Console.WriteLine();
    }
  }
  class Aplicativo {
    private int curtidas;
    private string nome, categoria;
    private decimal preco;
    public string Nome {
      get { return nome; }
      set { if (value.Length > 0) nome = value; }
    }
    public string Categoria {
      get { return categoria; }
      set { if (value.Length > 0) categoria = value; }
    }
    public decimal Preço {
      get { return preco; }
      set { if (value > 0) preco = value; }
    }
    public int Curtidas {
      get { return curtidas; }
    }
    public void Curtir(int c) {
      if (c > 0) curtidas = c;
    }
    public override string ToString() {
      return $"Nome: {nome} - Categoria: {categoria} - Preço: {preco:0.00} - Curtidas: {curtidas}";
    }
  }

  class Loja {
    Aplicativo[] la = new Aplicativo[20];
    private int k, qtd;
    private string nome;
    public string Nome {
      get { return nome; }
      set { if (value.Length > 0) nome = value; }
    }
    public int Qtd {
      get { 
        foreach (Aplicativo j in la) {
          if (j != null)
            qtd += 1;
        }
        return qtd; 
      }
    }
    public void Inserir(Aplicativo app) {
      la[k] = app;
      k++;
    }
    public void Excluir(Aplicativo app) {
      int i = Array.IndexOf(la, app);
      if (i != -1) {
        for (int m = i; m <= k; m++) {
          la[m] = la[m+1];
          k--;
        }
      }
    }
    public Aplicativo[] Listar() {
      return la;
    }
    
    public Aplicativo[] Pesquisar(string cat) {
      int y = 0;
      Aplicativo[] newLa = new Aplicativo[20];
      foreach (Aplicativo p in la) {
        if (p != null && p.Categoria == cat) {
          newLa[y++] = p;
        }
      }
      return newLa;
    }
  }