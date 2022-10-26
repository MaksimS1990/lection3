// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
// выводящее это число в консоль вместе с правильным образом изменённым словом "программист"

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int n = N % 10;
int nNew = N % 100;


if (nNew >= 10 && nNew <= 20)
{
    Console.WriteLine(N + " программистов");
}
else
{
    if (n == 1)
    {
        Console.WriteLine(N + " программист");
    }
    if (n >= 2 && n <= 4)
    {
    Console.WriteLine(N + " программиста");
    }
    if (n >= 5)
    {
        Console.WriteLine(N + " программистов");
    }
}