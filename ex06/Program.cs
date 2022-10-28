// Программа принимает на вход число и проверяет, кратно оно одновременно 7 и 23.
// 14, 46,161.

Console.WriteLine("Введите любое неотридцительное целое число");
int number = int.Parse(Console.ReadLine()!);
if (multiplicityTwoDigits(number)){
    Console.WriteLine("Введённое число кратно  и 7 и 23!");
}
else{
    Console.WriteLine("Нет! Введенное число не кратно 7 и 23!");
}

bool multiplicityTwoDigits(int number){
  return  number % 7 == 0 && number % 23 == 0;
}