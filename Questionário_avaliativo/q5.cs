using System;
  class MainClass {
    public static void Main(string[] args) {
      Playlist p = new Playlist();
      Musica m1 = new Musica("Deixa Eu te Usar", "Sarah Farias", new TimeSpan(0, 0, 04, 37));
      p.Inserir(m1);
      Musica m2 = new Musica("Oceanos", "Ana Nóbrega", new TimeSpan(0, 0, 08, 14));
      p.Inserir(m2);
      Musica m3 = new Musica("Maranata", "Banda Avivah", new TimeSpan(0, 0, 06, 18));
      p.Inserir(m3);
      Console.WriteLine($"Sua Playlist tem {p.Retorno()}. Dura {p.DuraçãoTotal()}.");
  }
}
  class Musica {
    private string nome, artista;
    private TimeSpan duração;
    public Musica(string nome, string artista, TimeSpan duração) {
      if (nome.Length > 0) { this.nome = nome; }
      if (artista.Length > 0) { this.artista = artista; }
      this.duração = duração;
    }
    public void SetNome(string nome) {
       if (nome.Length > 0) { this.nome = nome; }
    }
    public void SetArtista(string artista) {
       if (artista.Length > 0) { this.artista = artista; }
    }
    public void SetDuração(TimeSpan duração) {
       this.duração = duração;
    }
    public string GetNome() {
       return nome;
    }
    public string GetArtista() {
       return artista;
    }
    public TimeSpan GetDuração() {
       return duração;
    } 
  }
  class Playlist {
    Musica[] m = new Musica[20];
    int c = 0;
    public void Inserir(Musica n) {
      m[c] = n;
      c++;
    }
    public string Retorno() {
      string x = "";
      for (int i = 0; i < c; i++) {
        x += m[i].GetNome();
        if (i < c-1) {
          x += ", ";
        }
      }
      return x;
    }
    public TimeSpan DuraçãoTotal() {
      TimeSpan dt = new TimeSpan();
      for (int i = 0; i < c; i++) {
        dt += m[i].GetDuração();
      }
      return dt;
    }
  }