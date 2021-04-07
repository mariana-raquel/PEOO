using System;
  class MainClass {
    public static void Main(string[] args) {
      Media m = new Media();
      Console.WriteLine($"Qual disciplina você deseja calcular a média?");
      m.SetNome(Console.ReadLine());
      Console.WriteLine($"Digite a média dos quatro bimestres na disciplina de {m.GetNome()}:");
      m.SetNota1(int.Parse(Console.ReadLine()));
      m.SetNota2(int.Parse(Console.ReadLine()));
      m.SetNota3(int.Parse(Console.ReadLine()));
      m.SetNota4(int.Parse(Console.ReadLine()));
      if (m.mediap() < 60) {
        Console.WriteLine($"Digite a nota da prova final:");
        m.SetNotaFinal(int.Parse(Console.ReadLine()));
      }
      if (m.mediap() >= 60 || m.mediaf() >= 60) { Console.WriteLine($"Você foi aprovado. Sua média parcial ficou {m.mediap()} e sua média final ficou {m.mediaf()}");}
      if (m.mediap() < 60 && m.mediaf() < 60) { Console.WriteLine($"Você foi reprovado. Sua média parcial ficou {m.mediap()} e sua média final ficou {m.mediaf()}");}
    }
  }
  class Media {
    private string d;
    private int n1, n2, n3, n4, pf;
    public void SetNome(string s) {
      d = s;
    }
    public void SetNota1(int n) {
      if (n >= 0 && n <= 100) { n1 = n; }
    }
    public void SetNota2(int n) {
      if (n >= 0 && n <= 100) { n2 = n; }
    }
    public void SetNota3(int n) {
      if (n >= 0 && n <= 100) { n3 = n; }
    }
    public void SetNota4(int n) {
      if (n >= 0 && n <= 100) { n4 = n; }
    }
    public void SetNotaFinal(int n) {
      if (n >= 0 && n <= 100) { pf = n; }
    }

    public string GetNome() {
      return d;
    }
    public int GetNota1() {
      return n1;
    }
    public int GetNota2() {
      return n2;
    }
    public int GetNota3() {
      return n3;
    }
    public int GetNota4() {
      return n4;
    }
    public int GetNotaFinal() {
      return pf;
    }
    public int mediap() {
      int mp = ((n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3)) / 10;
      return mp;
    }
    public int mediaf() {
      if (mediap() >= 60) {return mediap();}
      else {
        int mf = (mediap() + pf) / 2;
        return mf;
      }
    }
  }