// напишите программу, которая вводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Программа вводит любое целое число от 10 до 99 и выводит в консоль наибольшую цифру числа!");
int randomNumber = new Random().Next(10, 100);
Console.WriteLine(randomNumber);
int B = randomNumber % 10;
int C = randomNumber / 10;

if (B > C){
    Console.WriteLine("Наибольшее число: " + B);
}
else{
    Console.WriteLine("Наибольшее число: " + C);
}