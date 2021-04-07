using System; 
  class MainClass {
    public static void Main (string[] args) {
      Estagiario e = new Estagiario("Mariana", "012.345.678-90", "91234-5678");
      Console.WriteLine(e);

    }
  }
  [Flags]
  enum Dias {
    nenhum = 0, segunda = 1, terça = 2, quarta = 4, quinta = 8, sexta = 16
  }
  enum Turno {
    matutino = 1, vespertino = 2, noturno = 3
  }
  class Estagiario {
    private string nome, cpf, telefone;
    private Dias dias;
    private Turno turno;
    public Estagiario (string n, string c, string t) {
      if (n.Length > 0) nome = n;
      if (c.Length > 0) cpf = c;
      if (t.Length > 0) telefone = t;
    }
    public void SetDias (Dias d) {
      dias = d;
    }
    public void SetTurno (Turno t) {
      turno = t;
    }
    public Dias GetDias() {
      return dias;
    }
    public Turno GetTurno() {
      return turno;
    }
    public override string ToString() {
      return $"Nome: {nome} - CPF: {cpf} - Telefone: {telefone} - Dias: {dias} - Turno: {turno}";
    }
  }