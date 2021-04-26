using System; 
  class MainClass {
    public static void Main (string[] args) {
      Premio p = new Premio("Mariana", DateTime.Parse("03/29/2021"), );
    }
  }
  class Premio {
    private string cliente;
    private DateTime data;
    private object premio;
    public Premio(string c, DateTime d) {
      if (c.Length > 0) cliente = c;
      if (d.Day > 0 && d.Month > 0) data = d;
    }
    public void SetPremio(object p) {

    }
    public object GetPremio() {

    }
    public override string ToString() {
      return $"Cliente: {cliente} - Data: {data} - Prêmio: {premio}";
    }
  }

  class ValeCompras {
    private DateTime dataValidade;
    private decimal valor;
    public ValeCompras(DateTime d, decimal v) {
      if (d.Day > 0 && d.Month > 0) dataValidade = d;
      if (v > 0) valor = v;
    }
    public override string ToString() {
      return $"Data de Validade: {dataValidade} - Valor: {valor}";
    }
  }

  class Produto {
    private string descrição;
    private decimal valor;
    public Produto(string d, decimal v) {
      if (d.Length > 0) descrição = d;
      if (v > 0) valor = v;
    }
    public override string ToString() {
      return $"Descrição: {descrição} - Valor: {valor}";
    }
  }