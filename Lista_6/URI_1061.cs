using System;
  class MainClass {
    public static void Main (string[] args) {
    
      string d1 = Console.ReadLine();
      int di = int.Parse(d1.Substring(4));
      string t1 = Console.ReadLine();
      int hi = int.Parse(t1.Substring(0,2));
      int mi = int.Parse(t1.Substring(5,2));
      int si = int.Parse(t1.Substring(10,2));

      string d2 = Console.ReadLine();
      int df = int.Parse(d2.Substring(4));
      string t2 = Console.ReadLine();
      int hf = int.Parse(t2.Substring(0,2));
      int mf = int.Parse(t2.Substring(5,2));
      int sf = int.Parse(t2.Substring(10,2));

      int d = df - di;
      int h = 24 + (hf - hi);
      int m = 60 + (mf - mi);
      int s = 60 + (sf - si);

      if (di == df) {d = 0; }
      if (hf == hi) { h -= 24; }
      if ((24 + (hf-hi)) < 24) { d -= 1; }
      if (h >= 24) { d+= 1; h -=24; }
      if (m >= 60) { m -= 60; h += 1; }
      if (s >= 60) { s -= 60; m +-1; }
  
      Console.WriteLine($"{d} dia(s)");
      Console.WriteLine($"{h} hora(s)");
      Console.WriteLine($"{m} minuto(s)");
      Console.WriteLine($"{s} segundo(s)");
  }
}

/*
using System;

class MainClass {
  public static void Main() { 
    string dia1 = Console.ReadLine();
    string horario1 = Console.ReadLine();
    string dia2 = Console.ReadLine();
    string horario2 = Console.ReadLine();

    int d1 = int.Parse(dia1.Substring(4));
    int h1 = int.Parse(horario1.Substring(0, 2));
    int m1 = int.Parse(horario1.Substring(5, 2));
    int s1 = int.Parse(horario1.Substring(10, 2));

    int d2 = int.Parse(dia2.Substring(4));
    int h2 = int.Parse(horario2.Substring(0, 2));
    int m2 = int.Parse(horario2.Substring(5, 2));
    int s2 = int.Parse(horario2.Substring(10, 2));

    int t1 = d1 * 86400 + h1 * 3600 + m1 * 60 + s1;
    int t2 = d2 * 86400 + h2 * 3600 + m2 * 60 + s2;

    int dif = t2 - t1;

    int nd = dif / 86400;
    dif = dif % 86400;

    int nh = dif / 3600;
    dif = dif % 3600;

    int nm = dif / 60;
    dif = dif % 60;
     
    Console.WriteLine($"{nd} dia(s)");
    Console.WriteLine($"{nh} hora(s)");
    Console.WriteLine($"{nm} minuto(s)");
    Console.WriteLine($"{dif} segundo(s)");
  }
}
*/
ne