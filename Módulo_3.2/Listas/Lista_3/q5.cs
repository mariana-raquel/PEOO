using System; 
  class MainClass {
    public static void Main(string[] args) {
      Data d = new Data(20, 04, 2021);
      Console.WriteLine(d);
      Data a = new Data("20/04/2021");
      Console.WriteLine(a);
    }
  }
  class Data {
    private int dia, mes, ano;
    public Data (int dia, int mes, int ano) {
      if (
        mes == 1 && dia > 0 && dia < 31 ||
        mes == 2 && dia > 0 && dia < 28 ||
        mes == 3 && dia > 0 && dia < 31 ||
        mes == 4 && dia > 0 && dia < 30 ||
        mes == 5 && dia > 0 && dia < 31 ||
        mes == 6 && dia > 0 && dia < 30 ||
        mes == 7 && dia > 0 && dia < 31 ||
        mes == 8 && dia > 0 && dia < 31 ||
        mes == 9 && dia > 0 && dia < 30 ||
        mes == 10 && dia > 0 && dia < 31 ||
        mes == 11 && dia > 0 && dia < 30 ||
        mes == 12 && dia > 0 && dia < 31)  {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
      }
    }
    public Data (string data) {
      string[] dt = data.Split("/");
      int a = int.Parse(dt[0]);
      int b = int.Parse(dt[1]);
      int c = int.Parse(dt[2]);
      if (
        b == 1 && a > 0 && a < 31 ||
        b == 2 && a > 0 && a < 28 ||
        b == 3 && a > 0 && a < 31 ||
        b == 4 && a > 0 && a < 30 ||
        b == 5 && a > 0 && a < 31 ||
        b == 6 && a > 0 && a < 30 ||
        b == 7 && a > 0 && a < 31 ||
        b == 8 && a > 0 && a < 31 ||
        b == 9 && a > 0 && a < 30 ||
        b == 10 && a > 0 && a < 31 ||
        b == 11 && a > 0 && a < 30 ||
        b == 12 && a > 0 && a < 31)  {
        dia = a;
        mes = b;
        ano = c;
      }
    }
    public void SetData (int dia, int mes, int ano) {
      if (
        mes == 1 && dia > 0 && dia < 31 ||
        mes == 2 && dia > 0 && dia < 28 ||
        mes == 3 && dia > 0 && dia < 31 ||
        mes == 4 && dia > 0 && dia < 30 ||
        mes == 5 && dia > 0 && dia < 31 ||
        mes == 6 && dia > 0 && dia < 30 ||
        mes == 7 && dia > 0 && dia < 31 ||
        mes == 8 && dia > 0 && dia < 31 ||
        mes == 9 && dia > 0 && dia < 30 ||
        mes == 10 && dia > 0 && dia < 31 ||
        mes == 11 && dia > 0 && dia < 30 ||
        mes == 12 && dia > 0 && dia < 31)  {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
        }
    }
    public int GetDia() {
      return dia;
    }
    public int GetMes() {
      return mes;
    }
    public int GetAno() {
      return ano;
    }
    public override string ToString() {
      if (dia == 0 || mes == 0) return $"Data Inválida";
      return $"{dia:00}/{mes:00}/{ano}";
    }
  }