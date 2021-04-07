using System; 
  class MainClass {
    public static void Main(string[] args) {
      Data d = new Data(29, 03, 2021);
      Console.WriteLine(d);
      Data a = new Data("29/03/2021");
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
      this.dia = int.Parse(dt[0]);
      this.mes = int.Parse(dt[1]);
      this.ano = int.Parse(dt[2]);
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
      return $"{dia}/{mes:00}/{ano}";
    }
  }