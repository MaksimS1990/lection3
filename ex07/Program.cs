// Напишите программу, которая принимает га вход 2 числа и проверяет, является ли одно число квадратом другого.
// 5 -> 25; -4 -> 16; 25 -> 5; 8 -> 9;
Console.WriteLine("Программа принимает 2 числа и проверяет, является ли одно, квадратом другого");
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);
if(IsSquare(number1, number2)){
    Console.WriteLine("Да, одно число является квадратом другого");
}
else{
    Console.WriteLine("Нет, ни одно из числел не является квадратом другого");
}
 bool IsSquare(int number1, int number2){
    return number1 == number2 * number2 || number2 == number1 * number1;
 }