using System;
class MainClass {
  public static void Main(string[] args) {
    int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    int x = 0;
    for (int i = 0; i < m.GetLength(0); i++)
      x += m[i, i];
    Console.WriteLine(x);
  }
}
