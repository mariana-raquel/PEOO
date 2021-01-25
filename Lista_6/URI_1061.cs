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
