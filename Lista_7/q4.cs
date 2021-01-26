using System;
  class MainClass {
    public static int MDC(int x, int y) {
      while (y != 0) {
        int r = x % y;
        x = y;
        y = r;
      }
      return x;
    }
    public static int MMC(int x, int y){
      int mmc = x * (y / MDC(x, y));
      return mmc;
    }
    public static void Main(string[] args) {
      int x = int.Parse(Console.ReadLine());
      int y = int.Parse(Console.ReadLine());
      Console.WriteLine(MMC(x, y));
    }
  }