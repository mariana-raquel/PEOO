using System; 
  class MainClass {
    public static void Main(string[] args) {
    Equacao e = new Equacao(0, 0, 0);
    Console.WriteLine("Informe os coeficientes da equação:");
    string[] c = Console.ReadLine().Split(" ");
    double v1 = double.Parse(c[0]);
    double v2 = double.Parse(c[1]);
    double v3 = double.Parse(c[2]);
    e.SetABC(v1, v2, v3);
    Console.WriteLine(e);
    Console.WriteLine($"Delta = {e.Delta()}");
    if (e.RaizesReais(out double x1, out double x2)) {
      Console.WriteLine($"X1 = {x1} e X2 = {x2}");
    }
    else { Console.WriteLine("Não possui raízes reais");}
  }
}
class Equacao {
  private double a, b, c;
  public Equacao(double a, double b, double c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }
  public void SetABC(double a, double b, double c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }
  public void GetABC(out double a, out double b, out double c) {
      a = this.a;
      b = this.b;
      c = this.c;
  }
  public double Delta() {
    double d = (b * b) - 4 * a * c;
    return d;
  }
  public bool RaizesReais(out double x1, out double x2) {
    x1 = 0;
    x2 = 0;
    if (Delta() == 0) { return false; }
    else {
      x1 = (-b + Math.Sqrt(Delta())) / (2*a);
      x2 = (-b - Math.Sqrt(Delta())) / (2*a);
      return true;
    }
  }
  public override string ToString() {
    return $"A = {a}, B = {b}, C = {c}";
  }
}
 


