using System;
  class MainClass {
    public static void Main (string[] args) {
      int e = int.Parse(Console.ReadLine());
      int s = 0;
      int c = 1;
      while (c <= e){
        int a = int.Parse(Console.ReadLine());
        int i = 1;
        while (a >= i) {
          if (a % i == 0 ) { s = s + 1; }
          i++;
        }
        if (s == 2) { Console.WriteLine("Prime"); }
        if (s != 2) { Console.WriteLine("Not Prime"); }
        s = 0;
        c++;
  }
}

/*
int e = int.Parse(Console.ReadLine());
int s = 0;
int c = 1;
do { 
  int a = int.Parse(Console.ReadLine());
  for (int i = 1; i <= a; i++){
    if (a % i == 0 ) { s = s + 1; } 
  }
  if (s == 2) { Console.WriteLine("Prime"); }
  if (s != 2) { Console.WriteLine("Not Prime"); }
  s = 0;
  c++;
} while (c <= e);
*/
/*
int e = int.Parse(Console.ReadLine());
int s = 0;
for (int c = 1; c <= e; c++){
  int a = int.Parse(Console.ReadLine());
  for (int i = 1; i <= a; i++){
    if (a % i == 0 ) { s = s + 1; } 
  }
  if (s == 2) { Console.WriteLine("Prime"); }
  if (s != 2) { Console.WriteLine("Not Prime"); }
   s = 0;
}
*/
/*
int e = int.Parse(Console.ReadLine());
int s = 0;
int c = 1;
while (c <= e){
  int a = int.Parse(Console.ReadLine());
  int i = 1;
  while (a >= i) {
    if (a % i == 0 ) { s = s + 1; }
    i++;
  }
  if (s == 2) { Console.WriteLine("Prime"); }
  if (s != 2) { Console.WriteLine("Not Prime"); }
  s = 0;
  c++;
}
*/