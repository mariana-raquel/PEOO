using System; 
  class MainClass {
    public static void Main(string[] args) {
      int[] v = { 1, 2, 3, 4, 5, 6, 7 };
      Array.Reverse(v);
      for (int i = 0; i < v.Length; i++) {
        if (i % 2 == 0) Console.WriteLine(v[i]);
      }
    }
  }
  /*class {
    
  }*/