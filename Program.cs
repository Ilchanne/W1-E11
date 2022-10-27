using System;
int result, a, b, c;
bool f;
string t;
    Console.WriteLine("Введите первую сторону треугольника");
do
{
    t = Console.ReadLine();
    f = int.TryParse(t, out a);
    if (f == false)
    {
        Console.WriteLine("Введите целое число!");
    }
}
while (f == false);

Console.WriteLine("Введите вторую сторону треугольника");
do {
    t = Console.ReadLine();
    f = int.TryParse(t, out b);
    if (f == false)
    {
        Console.WriteLine("Введите целое число!");
    }
}
while ( f == false);
Console.WriteLine("Введите третью сторону треугольника");
do
{
    t = Console.ReadLine();
    f = int.TryParse(t, out c);
    if (f == false)
    {
        Console.WriteLine("Введите целое число!");
    }
}
while (f == false);


if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}