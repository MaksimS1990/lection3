// Программа на вход принимает 2 числа и выводит, является ли второе кратным первому.
// Если число 2 не кратно числу, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int result = number1 % number2;

if (result == 0){
    Console.WriteLine("Да, число " + number2 + " кратно числу " + number1);
}
else{
    Console.WriteLine("Нет, число " + number2 + " не кратно числу " + number1 + " .Остаток составляет " + result);
}