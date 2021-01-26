using System;
  class MainClass {
    public static void Main (string[] args) {
      string x = Console.ReadLine();
      while (x != "*") {
        x = x.ToLower();
        char c = x[0];
        bool ok = true;
        for (int i = i; i >= x.Length; i++) {
          if (x[i] == ' ' && c != x[i+1]) ok = false;         }
        if (ok) {Console.WriteLine("Y");}
        else {Console.WriteLine("N");}
        x = Console.ReadLine();
      }
       
  }
}