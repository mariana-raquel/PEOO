using System; 
  class MainClass {
    public static void Main (string[] args) {
      Boleto b = new Boleto("aaaa", DateTime.Parse("03/10/2021"), DateTime.Parse("03/25/2021"), Convert.ToDecimal(102.50));
      b.Pagar(Convert.ToDecimal(102.50));
      Console.WriteLine(b);
    }
  }
  enum Pagamento : int {
    EmAberto = 1, PagoParcial = 2, Pago = 3
  }
  class Boleto {
    private string codBarras;
    private DateTime dataEmissao, dataVencimento, dataPagto;
    private decimal valorBoleto, valorPago;
    private Pagamento situacaoPagamento;

    public Boleto (string cod, DateTime emissao, DateTime venc, decimal valor) {
      if (cod.Length > 0) codBarras = cod;
      if (emissao.Day > 0 && emissao.Month > 0) dataEmissao = emissao;
      if (venc.Day > 0 && venc.Month > 0) dataVencimento = venc;
      if (valor > 0) valorBoleto = valor;
    }
    public void Pagar(decimal valorPago) {
      this.valorPago = valorPago;
    }
    public Pagamento Situação() {
      if (valorPago == 0) situacaoPagamento = Pagamento.EmAberto;
      if (valorPago < valorBoleto && valorPago > 0) situacaoPagamento = Pagamento.PagoParcial;
      if (valorPago == valorBoleto)  situacaoPagamento = Pagamento.Pago;
      return situacaoPagamento;
    }
    public override string ToString() {
      if (Situação() == Pagamento.PagoParcial || Situação() == Pagamento.Pago) {
        dataPagto = DateTime.Today; 
        return $"Código de Barras: {codBarras} - Data de Emissão: {dataEmissao:dd/MM/yyyy} - Data de Vencimento: {dataVencimento:dd/MM/yyyy} - Data do Pagamento: {dataPagto:dd/MM/yyyy} - Valor do boleto: {valorBoleto:0.00} - Valor pago: {valorPago:0.00} - Situação do Pagamento: {Situação()}";
      }
      else 
        return $"Código de Barras: {codBarras} - Data de Emissão: {dataEmissao:dd/MM/yyyy} - Data de Vencimento: {dataVencimento:dd/MM/yyyy} - Data do Pagamento: Ainda não foi pago - Valor do boleto: {valorBoleto:0.00} - Valor pago: {valorPago:0.00} - Situação do Pagamento: {Situação()}";
    }
  }
