using System;
  class MainClass {
    public static void Main (string[] args) {
      string s;
      while (string.IsNullOrEmpty (s = Console.ReadLine()) == false) {
      string[] e = s.Split(' ');
      double d = double.Parse(e[0]);
      double vf = double.Parse(e[1]);
      double vg = double.Parse(e[2]);
      
      double dg = Math.Sqrt((12*12) + (d*d));
      double tf = 12 / vf;
      double tg = dg / vg;
      if (tg <= tf) { 
        Console.WriteLine("S"); 
      }
      else { 
        Console.WriteLine("N"); 
      }
      
    }
  }
}