// Напишите программу, которая вводит случайное целое трёхзначное число и удаляет вторую цифру этого числа.
// 456  > 46
// 782 -> 72
// 918 - 98

Console.WriteLine("Программа вводит трехзначное число и удаляет вторую цифру.");

int random = new Random().Next(100, 1000);
Console.WriteLine(random);
int firstDigit = random / 100;
int secondDigit = random % 10;

Console.Write(firstDigit);
Console.Write(secondDigit);