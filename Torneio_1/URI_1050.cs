using System;
  class MainClass {
    public static void Main (string[] args) {
      string e = Console.ReadLine();
      if (e == "61") {
        Console.WriteLine("Brasilia");
      }
      if (e == "71") {
        Console.WriteLine("Salvador");
      }
      if (e == "11") {
        Console.WriteLine("Sao Paulo");
      }
      if (e == "21") {
        Console.WriteLine("Rio de Janeiro");
      }
      if (e == "32") {
        Console.WriteLine("Juiz de Fora");
      }
      if (e == "19") {
        Console.WriteLine("Campinas");
      }
      if (e == "27") {
        Console.WriteLine("Vitoria");
      }
      if (e == "31") {
        Console.WriteLine("Belo Horizonte");
      }
      if (e != "61" && e != "71" && e != "11" && e != "21" && e != "32" && e != "19" && e != "27" && e != "31") {
        Console.WriteLine("DDD nao cadastrado");
      }
      
      
  }
}