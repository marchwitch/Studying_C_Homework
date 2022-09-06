// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int num)
{
        int digit1 = num % 100;
        int digit2 = digit1 / 10;
        return digit2;
}

Console.WriteLine(ShowSecondDigit(number1));