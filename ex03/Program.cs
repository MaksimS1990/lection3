// напишите программу, которая вводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Программа вводит любое целое число от 10 до 99 и выводит в консоль наибольшую цифру числа!");

int GenerateRandomNumber() {
   return new Random().Next(10, 100);
}

int GetMaxDigitForTwoDigitsNumber(int randomNumber) {
    Console.WriteLine(randomNumber);
    int B = randomNumber % 10;
    int C = randomNumber / 10;

    int max = C;

    if (max > B)
        max = C;
    else max = B;
    
    return max;
} 
int randomNumber = GenerateRandomNumber();

int max = GetMaxDigitForTwoDigitsNumber(randomNumber);

Console.WriteLine("Наибольшая цифра: " + max);