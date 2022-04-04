// Находим максимальное значение из a,b,c,d.

int a = 23;
int b = 12;
int c = 341;
int d = 45;

int max = a;

if (b>a)   max = b;
if (c>b)    max = c;
if (d>c)  max = d;

Console.WriteLine(max + "  данное число является максимальным из заданных чисел");

