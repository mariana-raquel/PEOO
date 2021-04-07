using System; 
  class MainClass {
    public static void Main(string[] args) {
    Console.WriteLine("Qual número você deseja converter em binário?");
    Conversor c = new Conversor(0);
    c.SetNum(int.Parse(Console.ReadLine()));
    Console.WriteLine(c);
  }
}
class Conversor {
  private int num;
  public Conversor(int num) {
    this.num = num;
  }
  public void SetNum(int num) {
    this.num = num;
  }
  public int GetNum() {
    return num;
  }
  public string Binario() {
    int q = num;
    string bin = "";
    int r;
    while (q != 0) {
      r = q % 2;
      q = q / 2;
      bin = r + bin;
    }
    return bin;
  }
  public override string ToString() {
    return $"Decimal = {num} - Binário = {Binario()}";
  }
}
 

