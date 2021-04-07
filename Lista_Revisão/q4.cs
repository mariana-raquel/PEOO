using System;
  class MainClass {
    public static void Main(string[] args) {
      Intervalo i = new Intervalo();
    }
  }
  class Intervalo {
    private int hora, minuto, segundo;
    public void SetIntervalo(int h, int m, int s) {
      hora = h;
      minuto = m;
      segundo = s;
    }  
    public void GetIntervalo(out int h, out int m, out int s) {
      h = this.h;
      m = this.m;
      segundo = s;
    }  
  }