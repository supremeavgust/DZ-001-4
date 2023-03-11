//Задача 4
Console.Clear();
Console.Write("BBедите число:  ");
int a =Convert.ToInt32(Console.ReadLine());

Console.Write("BBедите число:  ");
int b =Convert.ToInt32(Console.ReadLine());

Console.Write("BBедите число:  ");
int c =Convert.ToInt32(Console.ReadLine());

int max=a;

if (a > max) max=a;
if (b > max) max=b;
if (c > max) max=c;
Console.Write($"Максимальное число:  {max}");
